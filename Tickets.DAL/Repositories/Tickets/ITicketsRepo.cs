using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;

namespace Tickets.DAL.Repositories.Tickets
{
    public interface ITicketsRepo
    {
        IEnumerable<Ticket> GetAll();
        Ticket? GetTicketWithDepartment(int id);
        Ticket? GetTicketWithDevelopers(int id);
        Ticket? GetTicketWithDevelopersAndDepartment(int id);
        void Add(Ticket ticket);
        void Update(Ticket ticket);
        void Delete(int id);
        int SaveChanges();
    }
}
