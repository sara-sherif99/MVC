using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.Identity.Database.Models;
using MVC.Identity.DTOs;
using System.Security.Claims;

namespace MVC.Identity.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UsersController(UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Authorized()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var user = new User
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                Gender =registerDto.Gender,
                DateOfBirth = registerDto.DOB
            };
            var creationResult = await _userManager.CreateAsync(user, registerDto.Password);
            if (!creationResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, creationResult.Errors.First().Description);
                return View();
            }

            var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id),
            new(ClaimTypes.Email, user.Email),
            new(ClaimTypes.Role, "User"),
        };

            await _userManager.AddClaimsAsync(user, claims);
            await _signInManager.SignInWithClaimsAsync(user, true, claims);

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto credentials)
        {
            var user = await _userManager.FindByEmailAsync(credentials.Email);
            if (user is null)
            {
                ModelState.AddModelError(string.Empty, "User Does not Exist");
                return View();
            }

            var isAuthenticated = await _userManager.CheckPasswordAsync(user,
                credentials.Password);
            if (!isAuthenticated)
            {
                ModelState.AddModelError(string.Empty, "Wrong Password");
                return View();
            }

            var claims = await _userManager.GetClaimsAsync(user);
            await _signInManager.SignInWithClaimsAsync(user, true, claims);

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
