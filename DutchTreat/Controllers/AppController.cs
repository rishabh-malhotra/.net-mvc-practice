using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController:Controller
    {
        public IActionResult Index()
        {
           // throw new InvalidOperationException("Bad Things Happened");

            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            
            //throw new InvalidOperationException("Bad Things Happened");
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {

            //throw new InvalidOperationException("Bad Things Happened");
            if (ModelState.IsValid)
            {
                //send the email
               // _mailService.SendMail(string to,string subject,string body){

                //}
            }
            else 
            {
                //show the errors

            }
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }

    
}
