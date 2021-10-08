using DemoSession.Infrastructure;
using DemoSession.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession.Controllers
{
    public class AuthController : Controller
    {
        private readonly ISessionManager _sessionManager;

        public AuthController(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm form)
        {
            _sessionManager.CurrentUser = new User() { Email = form.Email };
            return RedirectToAction("Index", "Home");
        }
    }
}
