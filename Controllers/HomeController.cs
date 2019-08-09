using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewFileFun.Models;

namespace viewFileFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "I will never be this young again. Ever. Oh damn… I just got older. Don't step on the broken glass. A song can make or ruin a person’s day if they let it get to them. I was very proud of my nickname throughout high school but today- I couldn’t be any different to what my nickname was. I want more detailed information. The quick brown fox jumps over the lazy dog. The shooter says goodbye to his love. I checked to make sure that he was still alive. The lake is a long way from here. He ran out of money, so he had to stop playing poker.";
            return View("Index", message);
        }
        [HttpGet("numbers")]

        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5,6,7,8,9
            };
            return View("Numbers", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<string> userNames = new List<string>();
            userNames.Add("Cody Baermann");
            userNames.Add("Ryan Baermann");
            userNames.Add("Kasey Baermann");
            userNames.Add("Emma Baermann");
            userNames.Add("Sadie Baermann");
            return View("Users", userNames);
        }

        [HttpGet("user")]

        public IActionResult UserProfile()
        {
           User someUser = new User()
           {
               FirstName = "Kasey",
               LastName = "Baermann"
           };
           return View("User", someUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
