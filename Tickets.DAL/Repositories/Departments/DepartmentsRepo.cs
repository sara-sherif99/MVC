using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Context;
using Tickets.DAL.Models;

namespace Tickets.DAL.Repositories.Departments
{
    public class DepartmentsRepo : IDepartmentsRepo
    {
        private readonly TicketsContext _context;
        public DepartmentsRepo(TicketsContext context)
        {
            _context = context;
        }
        public IEnumerable<Department> GetAll()
        {
            return _context.Set<Department>();
        }
        public Department? Get(Guid id)
        {
            return _context.Set<Department>().Find(id);
        }

    }
}
