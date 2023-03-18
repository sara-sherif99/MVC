using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tickets.DAL.Context;
using Tickets.DAL.Models;

namespace Tickets.DAL.Repositories.Tickets
{
    public class TicketsRepo : ITicketsRepo
    {
        private readonly TicketsContext _context;

        public TicketsRepo(TicketsContext context)
        {
            _context = context;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _context.Set<Ticket>()
                .Include(t => t.Department)
                .Include(t => t.Developers);
        }


        public void Add(Ticket ticket)
        {
            _context.Set<Ticket>().Add(ticket);
        }

        public void Update(Ticket ticket)
        {
        }

        public void Delete(int id)
        {
            var ticketToDelete = GetTicketWithDevelopersAndDepartment(id);
            if (ticketToDelete != null)
            {
                _context.Set<Ticket>().Remove(ticketToDelete);
            }
        }

        public Ticket? GetTicketWithDepartment(int id)
        {
            return _context.Set<Ticket>()
                .Include(t=>t.Department)
                .FirstOrDefault(t=>t.Id==id);
        }

        public Ticket? GetTicketWithDevelopers(int id)
        {
            return _context.Set<Ticket>()
                .Include(t => t.Developers)
                .FirstOrDefault(t => t.Id == id);
        }

        public Ticket? GetTicketWithDevelopersAndDepartment(int id)
        {
            return _context.Set<Ticket>()
                 .Include(t => t.Department)
                 .Include(t => t.Developers)
                 .FirstOrDefault(t => t.Id == id);
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
