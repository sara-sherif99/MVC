using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.BL.ViewModels;
using Tickets.DAL.Models;

namespace Tickets.BL.Managers.Developers
{
    public interface IDevelopersManager
    {
        IEnumerable<SelectListItem> GetAll();
        Developer? Get(Guid id);
    }
}
