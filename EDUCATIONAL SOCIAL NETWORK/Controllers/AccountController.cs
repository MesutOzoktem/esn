using DataLayer.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EDUCATIONAL_SOCIAL_NETWORK.Controllers
{
    public class AccountController : Controller
    {
        private AccountOperations operations = new AccountOperations();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string mail,string password)
        {
            if (IsValidEmailAddress(mail))
            {
                var result = operations.Login(mail, password);
                if (result.Status == 1)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = result.Message;
                    return View();
                }
            }
            else
            {
                ViewBag.Error = "Please enter proper email address";
                return View();
            }
            
            
        }
        private static bool IsValidEmailAddress(string emailAddress)
        {
            return new System.ComponentModel.DataAnnotations
                                .EmailAddressAttribute()
                                .IsValid(emailAddress);
        }


    }
}