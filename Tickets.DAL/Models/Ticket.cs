using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tickets.DAL.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public Severity Severity { get; set; }
        [ForeignKey("Department")]
        public Guid DeptId { get; set; }
        public Department? Department { get; set; }
        public ICollection<Developer>? Developers { get; set; } = new HashSet<Developer>();
        public string? Image { set; get; }
    }
    public class Developer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
        public Developer()
        {

        }

        public Developer(Guid _Id,string _FirstName,string _LastName)
        {
            Id=_Id;
            FirstName=_FirstName;
            LastName=_LastName;
        }

    }

    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Ticket>? Tickets { get; set; } = new HashSet<Ticket>();
        public Department()
        {

        }
        public Department(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public enum Severity
    {
        Low,
        Medium,
        High
    }
}
