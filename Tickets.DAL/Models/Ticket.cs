﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
    }
    public enum Severity
    {
        Low,
        Medium,
        High
    }
}
