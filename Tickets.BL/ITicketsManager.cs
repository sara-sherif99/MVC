using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.BL.ViewModels;

namespace Tickets.BL
{
    public interface ITicketsManager
    {
        List<TicketsVM> GetAll();
        TicketsVM? Get(int id);
        void Add(TicketsVM ticket);
        void Delete(TicketsVM ticket);
        void Update(EditTicketsVM ticket);

    }
}
