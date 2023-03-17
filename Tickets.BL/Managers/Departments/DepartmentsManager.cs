using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;
using Tickets.DAL.Repositories.Departments;
using Tickets.DAL.Repositories.Developers;

namespace Tickets.BL.Managers.Departments
{
    public class DepartmentsManager : IDepartmentsManager
    {
        private readonly IDepartmentsRepo _departmentsRepo;

        public DepartmentsManager(IDepartmentsRepo departmentsRepo)
        {
            _departmentsRepo = departmentsRepo;
        }
        public Department? Get(Guid id)
        {
            var department = _departmentsRepo.Get(id);
            if (department == null)
            {
                return null;
            }
            return new Department(department.Id,department.Name);
        }

        public IEnumerable<SelectListItem> GetAll()
        {
            var developers = _departmentsRepo.GetAll();
            return developers.Select(t => new SelectListItem(t.Name, t.Id.ToString()));
        }
    }
}
