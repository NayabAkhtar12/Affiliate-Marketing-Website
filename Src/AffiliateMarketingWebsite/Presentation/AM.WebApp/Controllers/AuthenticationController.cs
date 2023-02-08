using AM.WebApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Security.Claims;

namespace AM.WebApp.Controllers
{
    public class AuthenticationController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            //Logic to compare User From Database

            try
            {
                //creating list of claims
                var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, model.Email)

            };
                //claimsIdentity
                var claimIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                //creating claims principal object to pass to the sign in Method
                var ClaimsPrincipal = new ClaimsPrincipal(claimIdentity);

                //signing In
                await HttpContext.SignInAsync(ClaimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                    return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await this.HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        }
}
