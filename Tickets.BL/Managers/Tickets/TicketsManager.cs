using Tickets.BL.ViewModels;
using Tickets.DAL.Models;
using Tickets.DAL.Repositories.Departments;
using Tickets.DAL.Repositories.Developers;
using Tickets.DAL.Repositories.Tickets;

namespace Tickets.BL.Managers.Tickets
{
    public class TicketsManager : ITicketsManager
    {
        private readonly ITicketsRepo _ticketsRepo;

        private readonly IDepartmentsRepo _departmentsRepo;
        private readonly IDevelopersRepo _developersRepo;

        public TicketsManager(ITicketsRepo ticketsRepo, IDepartmentsRepo departmentsRepo, IDevelopersRepo developersRepo)
        {
            _ticketsRepo = ticketsRepo;
            _departmentsRepo = departmentsRepo;
            _developersRepo = developersRepo;
        }

        void ITicketsManager.Add(AddTicketsVM ticket)
        {
            var newticket = new Ticket
            {
                Id = ticket.Id,
                Title = ticket.Title,
                Description = ticket.Description,
                Severity = ticket.Severity,
                DeptId=ticket.DeptId,
                Department = _departmentsRepo.Get(ticket.DeptId),
                Developers = _developersRepo.GetAll().Where(d => ticket.Developers.Contains(d.Id)).ToList()


        };

            _ticketsRepo.Add(newticket);
            _ticketsRepo.SaveChanges();
        }

        void ITicketsManager.Delete(ViewTicketsVM ticket)
        {
            _ticketsRepo.Delete(ticket.Id);
            _ticketsRepo.SaveChanges();
        }

        ViewTicketsVM? ITicketsManager.Get(int id)
        {
            var ticket = _ticketsRepo.Get(id);
            if (ticket == null)
            {
                return null;
            }
            return new ViewTicketsVM
                (
                    ticket.Id, 
                    ticket.Title, 
                    ticket.Description, 
                    ticket.Severity,
                    ticket.Department?.Name??"",
                    ticket.Developers?.Count()??0
                 );
        }
        EditTicketsVM? ITicketsManager.GetToEdit(int id)
        {
            //TODO: You could enhance performance here by implement a new method in the repo
            // GetWithDevelopers()
            //Which will get the ticket and join with the developers
            //but without joining with the departments
            //and replace this ticket.Department.Id 
            //with this ticket.DeptId,
            var ticket = _ticketsRepo.Get(id);
            var newTicket = new EditTicketsVM
            (
                ticket.Id,
                ticket.Title,
                ticket.Description,
                ticket.Severity,
                ticket.DeptId,
                //ticket.Department.Id,
                ticket.Developers.Select(d=>d.Id).ToArray()

            );
            return newTicket;
        }

        List<ViewTicketsVM> ITicketsManager.GetAll()
        {
            var tickets = _ticketsRepo.GetAll();
            return tickets.Select(t => new ViewTicketsVM(t.Id, t.Title, t.Description, t.Severity,t.Department?.Name??"",t.Developers?.Count()??0))
                .ToList();
        }

        void ITicketsManager.Update(EditTicketsVM newTicket)
        {
            var ticket = _ticketsRepo.Get(newTicket.Id);
            ticket.Title = newTicket.Title;
            ticket.Description = newTicket.Description;
            ticket.Severity = newTicket.Severity;
            ticket.DeptId=newTicket.DeptId;
            ticket.Developers = _developersRepo.GetAll().Where(d=>newTicket.Developers.Contains(d.Id)).ToList();
            _ticketsRepo.SaveChanges();
        }
    }
}