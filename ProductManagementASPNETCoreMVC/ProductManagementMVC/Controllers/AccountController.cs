using Microsoft.AspNetCore.Mvc;
using Repositories.Entities;
using Services.Interfaces;

namespace ProductManagementMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountMember model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _accountService.GetUser(model.EmailAddress);
            if (user == null || !_accountService.CheckPassword(user, model.MemberPassword))
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }

            HttpContext.Session.SetString("UserEmail", user.EmailAddress);
            return RedirectToAction("Index", "Products");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
