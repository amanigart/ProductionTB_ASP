using AppASP.Models;
using AppASP.Tools;
using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AppASP.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserRepository _serviceUser;
        private readonly SessionManager _sessionManager;

        public AuthController(IUserRepository serviceUser, SessionManager session)
        {
            _serviceUser = serviceUser;
            _sessionManager = session;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm form)
        {
            if (!ModelState.IsValid) return View(form);

            try
            {
                User currentUser = _serviceUser.Login(form.Email, form.Passwd).DalUserToAspUser();
                _sessionManager.CurrentUser = currentUser;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.LoginError = "Mauvais Login ou mot de passe.";
                /*Console.WriteLine(ex.Message);*/
                return View(form);
            }
        }

        public IActionResult LogOut()
        {
            _sessionManager.Disconnect();
            return RedirectToAction("Login");
        }

    }
}
