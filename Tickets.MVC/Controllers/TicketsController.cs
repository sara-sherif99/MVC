using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net.Sockets;
using Tickets.BL.Managers.Departments;
using Tickets.BL.Managers.Developers;
using Tickets.BL.Managers.Tickets;
using Tickets.BL.ViewModels;
using Tickets.DAL.Models;

namespace Tickets.MVC.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketsManager _ticketsManager;
        private readonly IDepartmentsManager _departmentsManager;
        private readonly IDevelopersManager _developersManager;

        public TicketsController(ITicketsManager ticketsManager, IDepartmentsManager departmentsManager, IDevelopersManager developersManager)
        {
            _ticketsManager = ticketsManager;
            _departmentsManager = departmentsManager;
            _developersManager = developersManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return View(_ticketsManager.GetAll());
        }
        public IActionResult Details(int id)
        {
            var ticket =_ticketsManager.Get(id);
            if (ticket is null)
            {
                View("NotFound");
            }
            return View(ticket);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Departments = _departmentsManager.GetAll();
            ViewBag.Developers = _developersManager.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddTicketsVM ticket)
        {
            if (ticket.Image.Length > 1000_000)
            {
                ModelState.AddModelError("", "Image size exceeded the limit");
                return View();
            }
            var allowedExtensions = new string[] { ".png", ".svg" };
            var sentExtension = Path.GetExtension(ticket.Image.FileName).ToLower();
            if (!allowedExtensions.Contains(sentExtension))
            {
                ModelState.AddModelError("", "Image extension is not valid");
                return View();
            }
            string newName = $"{Guid.NewGuid()}{sentExtension}";
            ticket.ImageName=newName;
            string fullPath = @$"D:\sara\iti9\mvc\day4\lab4\lab4\Tickets.MVC\wwwroot\images\{newName}";

            using (var stream = System.IO.File.Create(fullPath))
            {
                ticket.Image.CopyTo(stream);
            }
            _ticketsManager.Add(ticket);
            return RedirectToAction(nameof(GetAll));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var newTicket=_ticketsManager.GetToEdit(id);
            ViewBag.Departments = _departmentsManager.GetAll();
            ViewBag.Developers = _developersManager.GetAll();
            return View(newTicket);
        }
        [HttpPost]
        public IActionResult Edit(EditTicketsVM ticket)
        {
            if(ticket.Image != null)
            {
                if (ticket.Image.Length > 1000_000)
                {
                    ModelState.AddModelError("", "Image size exceeded the limit");
                    return View();
                }
                var allowedExtensions = new string[] { ".png", ".svg" };
                var sentExtension = Path.GetExtension(ticket.Image.FileName).ToLower();
                if (!allowedExtensions.Contains(sentExtension))
                {
                    ModelState.AddModelError("", "Image extension is not valid");
                    return View();
                }
                string newName = $"{Guid.NewGuid()}{sentExtension}";
                ticket.ImageName = newName;
                string fullPath = @$"D:\sara\iti9\mvc\day4\lab4\lab4\Tickets.MVC\wwwroot\images\{newName}";

                using (var stream = System.IO.File.Create(fullPath))
                {
                    ticket.Image.CopyTo(stream);
                }
            }
            
            _ticketsManager.Update(ticket);
            return RedirectToAction(nameof(GetAll));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var ticketToDelete = _ticketsManager.Get(id);
            _ticketsManager.Delete(ticketToDelete);

            return RedirectToAction(nameof(GetAll));
        }

        public IActionResult ValidateTitle(string title)
        {
            if (_ticketsManager.GetAll().Any(t=>t.Title==title))
            {
                return Json($"{title} is taken");
            }
            return Json(true);
        }

    }
}
