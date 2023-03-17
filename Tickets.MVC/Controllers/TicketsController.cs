using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Edit(EditTicketsVM newTicket)
        {
            _ticketsManager.Update(newTicket);
            return RedirectToAction(nameof(GetAll));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var ticketToDelete = _ticketsManager.Get(id);
            _ticketsManager.Delete(ticketToDelete);

            return RedirectToAction(nameof(GetAll));
        }
    }
}
