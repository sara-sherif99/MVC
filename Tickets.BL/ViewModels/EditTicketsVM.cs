using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.DAL.Models;
using Severity = Tickets.DAL.Models.Severity;

namespace Tickets.BL.ViewModels
{ 
    public class EditTicketsVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Severity Severity { get; set; }

        [Display(Name = "Department")]
        public Guid DeptId { get; set; }
        public Guid[]? Developers { get; set; } = Array.Empty<Guid>();
        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; }
        public EditTicketsVM()
        {

        }
        public EditTicketsVM(int _Id, string _Title, string _Description,
            Severity _Severity, Guid _DeptId, Guid[] _Developers,
            string _ImageName)
        {
            Id = _Id;
            Title = _Title;
            Description = _Description;
            Severity = _Severity;
            DeptId = _DeptId;
            Developers = _Developers;
            ImageName = _ImageName;

        }

    }
}
