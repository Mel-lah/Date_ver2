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
            List<User> users = GenerateRandomUsers(100);

            return View(users);
        }

        public ActionResult About()
        {
            List<User> users = GenerateRandomUsers(100);

            return View(users);
        }

        private List<User> GenerateRandomUsers(int count)
        {
            List<User> users = new List<User>();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                User user = new User
                {
                    Id = GenerateUniqueRandomId(users, random),
                    Name = GenerateRandomName(random),
                    Address = GenerateRandomAddress(random),
                    Country = GenerateRandomCountry(random)
                };

                users.Add(user);
            }

            return users;
        }

        private int GenerateUniqueRandomId(List<User> existingUsers, Random random)
        {
            int newId;

            do
            {
                newId = random.Next(1000, 10000); // Generate a random ID between 1000 and 9999
            }
            while (existingUsers.Any(u => u.Id == newId));

            return newId;
        }

        private string GenerateRandomName(Random random)
        {
            string[] names = { "John", "Jane", "Robert", "Emily", "Michael", "Emma", "William", "Olivia", "James", "Ava" };
            return names[random.Next(names.Length)] + " " + names[random.Next(names.Length)];
        }

        private string GenerateRandomAddress(Random random)
        {
            string[] streets = { "Main St", "Elm St", "Maple Ave", "Oak Rd", "Cedar Ln" };
            int houseNumber = random.Next(1, 1000);
            string streetName = streets[random.Next(streets.Length)];
            return $"{houseNumber} {streetName}";
        }

        private string GenerateRandomCountry(Random random)
        {
            string[] countries = { "USA", "Canada", "UK", "Australia", "Germany", "France", "Japan", "China", "India", "Brazil" };
            return countries[random.Next(countries.Length)];
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}