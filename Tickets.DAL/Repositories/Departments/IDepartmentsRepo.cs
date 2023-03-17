using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;

namespace Tickets.DAL.Repositories.Departments
{
    public interface IDepartmentsRepo
    {
        IEnumerable<Department> GetAll();
        Department? Get(Guid id);
    }
}
