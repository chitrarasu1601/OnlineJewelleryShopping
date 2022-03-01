using Mvcjewellery1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvcjewellery1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            Customer customer = new Customer();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Login(Customer customer)
        {
            int customerid = 0;
            string password = "";
            MvcJewelleryEntities1 db = new MvcJewelleryEntities1();
            foreach(Customer customer1 in db.Customers)
            {
                if(customer1.UserName == customer.UserName)
                {
                    customerid = customer1.ID;
                    password = customer1.Password;
                    break;
                }
            }
            if(customerid == 0)
            {
                ViewData["NoUser"] = "User Not Found";
                return View(customer);
            }
            else
            {
                if(password == customer.Password)
                {
                    return Content("Login Success");
                }
                else
                {
                    ViewData["WrongPass"] = "Wrong Password";
                    return View(customer);
                }
            }
        }
    }
}