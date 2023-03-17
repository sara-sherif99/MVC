using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.BL.ViewModels;
using Tickets.DAL.Models;
using Tickets.DAL.Repositories;
using Tickets.DAL.Repositories.Developers;

namespace Tickets.BL.Managers.Developers
{
    public class DevelopersManager : IDevelopersManager
    {
        private readonly IDevelopersRepo _devsRepo;

        public DevelopersManager(IDevelopersRepo devsRepo)
        {
            _devsRepo = devsRepo;
        }
        public Developer? Get(Guid id)
        {
            var developer = _devsRepo.Get(id);
            if (developer == null)
            {
                return null;
            }
            return new Developer(developer.Id,developer.FirstName,developer.LastName);
        }

        public IEnumerable<SelectListItem> GetAll()
        {
            var developers = _devsRepo.GetAll();
            return developers.Select(t => new SelectListItem($"{t.FirstName} {t.LastName}", t.Id.ToString()));
        }
    }
}
