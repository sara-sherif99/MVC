using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;

namespace Tickets.DAL.Repositories.Developers
{
    public interface IDevelopersRepo
    {
        IEnumerable<Developer> GetAll();
        Developer? Get(Guid id);
    }
}
