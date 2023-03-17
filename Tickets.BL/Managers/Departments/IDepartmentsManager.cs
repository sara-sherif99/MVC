using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;

namespace Tickets.BL.Managers.Departments
{
    public interface IDepartmentsManager
    {
        IEnumerable<SelectListItem> GetAll();
        Department? Get(Guid id);
    }
}
