using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web1.Models;
using Web1.Models.ViewModels;

namespace Web1.Controllers
{
    public class AuthorizeController:Controller
    {
        Context context;
        public AuthorizeController(Context context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Client client = await context.Clients.FirstOrDefaultAsync(u =>
                    u.email == model.Email); //u.password == model.Password));
               
                if (client != null && client.password==model.Password)
                {
                 
                    await Authenticate(client); // аутентификация
                   
                    return RedirectToAction("Index", "State");
                }

                ModelState.AddModelError("Email", "Incorrect login or password");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Client client = await context.Clients.FirstOrDefaultAsync(c => c.email == model.Email);
                
                if (client == null)
                {
                 
                    Client curClient = new Client
                    {
                        firstname = model.FirstName, lastname = model.LastName, email = model.Email,
                        role = model.Role, password =model.Password
                    };
                    context.Clients.Add(curClient);
                    
                    await context.SaveChangesAsync();

                    await Authenticate(curClient); 

                    return RedirectToAction("Index", "State");
                }

                ModelState.AddModelError("Email", "Incorrect login or password");
            }

            return View(model);
        }

        private async Task Authenticate(Client client)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, client.email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, client.role)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Authorize");
        }
    }
}