using MVC.Identity.Database.Models;

namespace MVC.Identity.DTOs
{
    
    public record RegisterDto(string UserName, string Password, string Email,Gender Gender, DateTime DOB);

}
