using Tickets.BL.ViewModels;
using Tickets.DAL.Models;
using Tickets.DAL.Repositories;
namespace Tickets.BL
{
    public class TicketsManager : ITicketsManager
    {
        private readonly ITicketsRepo _ticketsRepo;

        public TicketsManager(ITicketsRepo ticketsRepo)
        {
            _ticketsRepo = ticketsRepo;
        }

        void ITicketsManager.Add(TicketsVM ticket)
        {
            var newticket = new Ticket
            {
                Id=ticket.Id,
                Title=ticket.Title,
                Description=ticket.Description,
                Severity=ticket.Severity,
               
            };

            _ticketsRepo.Add(newticket);
            _ticketsRepo.SaveChanges();
        }

        void ITicketsManager.Delete(TicketsVM ticket)
        {
            _ticketsRepo.Delete(ticket.Id);
            _ticketsRepo.SaveChanges();
        }

        TicketsVM? ITicketsManager.Get(int id)
        {
            var ticket = _ticketsRepo.Get(id);
            if (ticket == null)
            {
                return null;
            }
            return new TicketsVM(ticket.Id,ticket.Title,ticket.Description,ticket.Severity);
        }

        List<TicketsVM> ITicketsManager.GetAll()
        {
            var tickets = _ticketsRepo.GetAll();
            return tickets.Select(t => new TicketsVM(t.Id,t.Title,t.Description,t.Severity))
                .ToList();
        }

        void ITicketsManager.Update(EditTicketsVM newTicket)
        {
            var ticket = _ticketsRepo.Get(newTicket.Id);
            ticket.Title = newTicket.Title;
            ticket.Description = newTicket.Description;
            ticket.Severity = newTicket.Severity;
            _ticketsRepo.SaveChanges();
        }
    }
}