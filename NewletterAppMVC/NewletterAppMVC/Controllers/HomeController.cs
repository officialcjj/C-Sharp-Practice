using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = new SignUp();
                signup.FirstName = firstName;
                signup.LastName = lastName;
                signup.EmailAddress = emailAddress;

                db.SignUps.Add(signup);
                db.SaveChanges();
            }
            return View("Success");
        }
    }
}