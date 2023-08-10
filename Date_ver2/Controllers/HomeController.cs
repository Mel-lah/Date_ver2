using Date_ver2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Date_ver2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Address = "123 Main St", Country = "USA" },
                new User { Id = 2, Name = "Jane Smith", Address = "456 Elm St", Country = "Canada" }
                // Add more user instances as needed
               
            };

            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}