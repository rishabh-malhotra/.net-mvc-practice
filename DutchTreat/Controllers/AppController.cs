using DutchTreat.Data;
using DutchTreat.services;
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
        private readonly IMailService _mailService;
        private readonly DutchContext _context;

        public AppController(IMailService mailService,DutchContext context)
        {
            _mailService = mailService;
            _context = context;
        }
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
                _mailService.SendMessage("rishabhmalhotra110796gmail.com ", model.Subject, $"From: {model.Name} - {model.Email},Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent..";
                ModelState.Clear();
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
        public IActionResult Shop()
        {
            //var results = _context.Products
            //.OrderBy(p=>p.Category).ToList();

            //also be done by:-

            var results = from p in _context.Products
                          orderby p.Category
                          select p;
            
 
            return View(results.ToList());
        }
    }

    
}
