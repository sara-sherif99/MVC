using lab2.Models.Domain;
using lab2.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Metrics;

namespace lab2.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            var tickets = Ticket.GetTickets();
            return View(tickets);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TicketVM ticket)
        {
            Ticket.AddtoTickets(ticket);
            return RedirectToAction(nameof(GetAll));
            //return View();
        }

    }

}
