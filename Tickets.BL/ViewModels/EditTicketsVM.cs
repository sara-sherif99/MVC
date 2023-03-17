﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;

namespace Tickets.BL.ViewModels
{
    public record EditTicketsVM(int Id,string Title, string Description, Severity Severity, [Display(Name = "Department")]  Guid DeptId, Guid[] Developers)
    {
        


    }
}
