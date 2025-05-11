using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Wonderwave.Models;

namespace Wonderwave.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult MainMenu()
        {
            return View();
        }

        public ActionResult Sales()
        {
            return View();
        }

        public ActionResult Employees()
        {
            return View();
        }


        public ActionResult Employeeslist()
        {
            return View();
        }


        public ActionResult Settings()
        {
            return View();
        }

        public ActionResult Inventory()
		{
            return View();
        }


        public ActionResult Login()
		{
            return View();
        }
        public ActionResult Register()
		{
            return View();
        }

    }
}
