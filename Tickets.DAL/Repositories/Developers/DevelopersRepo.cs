using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Context;
using Tickets.DAL.Models;

namespace Tickets.DAL.Repositories.Developers
{
    public class DevelopersRepo:IDevelopersRepo
    {
        private readonly TicketsContext _context;

        public DevelopersRepo(TicketsContext context)
        {
            _context = context;
        }

        public IEnumerable<Developer> GetAll()
        {
            return _context.Set<Developer>();
        }

        public Developer? Get(Guid id)
        {
            return _context.Set<Developer>().Find(id);
        }
    }
}
