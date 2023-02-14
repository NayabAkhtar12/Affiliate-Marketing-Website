using AM.Business.Models;
using AM.WebApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SM.Business.DataServices;
using System.Linq.Expressions;
using System.Security.Claims;
using LoginModel = AM.Business.Models.LoginModel;
using AM.WebApp;
namespace AM.WebApp.Controllers
{
public class AuthenticationController : Controller
    {
        private readonly AuthService authService;

        public AuthenticationController()
        {
            authService = new AuthService();
        }
        public ActionResult Index()
        {
            return View();
        }
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
            catch (Exception ex)
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await this.HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        public ActionResult Register()
        {
            var model = new RegisterModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await authService.Register(model);

                if (result.IsSuccessful)
                {
                    ViewBag.Message = result.Message;

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = result.Message;

                    return View(model);
                }
            }

            return View(model);
        }
    }
}
      

 
