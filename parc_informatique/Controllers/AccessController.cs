using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using parc_informatique.Models;
using ParcInformatique.Web.Models;
using ParcInformatique.Data.Entities;

namespace ParcInformatique.Web.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimeUser = HttpContext.User;

            if (claimeUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            if (modelLogin.Email == "Utilisateur@example.com" &&
               modelLogin.PassWord == "123"
               )
            {
                List<Claim> claims = new List<Claim>()
               {
                   new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                   new Claim("OtherProperties","Example Role")
               };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                   CookieAuthenticationDefaults.AuthenticationScheme );

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                   new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }
            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}
