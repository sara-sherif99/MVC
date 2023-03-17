using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.BL.ViewModels;

namespace Tickets.BL.Managers.Tickets
{
    public interface ITicketsManager
    {
        List<ViewTicketsVM> GetAll();
        ViewTicketsVM? Get(int id);
        EditTicketsVM? GetToEdit(int id);
        void Add(AddTicketsVM ticket);
        void Delete(ViewTicketsVM ticket);
        void Update(EditTicketsVM ticket);

    }
}
