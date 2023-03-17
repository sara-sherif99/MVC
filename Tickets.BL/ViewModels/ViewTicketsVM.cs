using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;

namespace Tickets.BL.ViewModels
{
    public class ViewTicketsVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Severity Severity { get; set; }
        [Display(Name = "Department Name")]
        public string? DeptName { get; set; }
        public int DevelopersCount { get; set; }

        public ViewTicketsVM()
        {

        }
        public ViewTicketsVM(int _Id, string _Title, string _Description, Severity _Severity, string _DeptName, int _DevelopersCount)
        {
            Id = _Id;
            Title = _Title;
            Description = _Description;
            Severity = _Severity;
            DeptName = _DeptName;
            DevelopersCount = _DevelopersCount;

        }
    }
}
