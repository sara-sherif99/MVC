using Microsoft.AspNetCore.Mvc;
using Tickets.BL;
using Tickets.BL.ViewModels;
using Tickets.DAL.Models;

namespace Tickets.MVC.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketsManager _ticketsManager;

        public TicketsController(ITicketsManager ticketsManager)
        {
            _ticketsManager = ticketsManager;
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
            return View();
        }
        [HttpPost]
        public IActionResult Add(TicketsVM ticket)
        {
            _ticketsManager.Add(ticket);
            return RedirectToAction(nameof(GetAll));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var ticket = _ticketsManager.Get(id);
            var newTicket = new EditTicketsVM
            (
                ticket.Id,
                ticket.Title,
                ticket.Description,
                ticket.Severity

            );
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
