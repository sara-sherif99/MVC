using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Identity.Database.Models
{
    public class User : IdentityUser
    {
        public Gender Gender { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}
