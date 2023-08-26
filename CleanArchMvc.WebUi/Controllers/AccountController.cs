using CleanArch.Domain.Account;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticate _authentication;
        public AccountController(IAuthenticate authentication)
        {
            _authentication = authentication;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
