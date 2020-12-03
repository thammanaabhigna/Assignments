using DatabaseFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace DatabaseFirstApp.Controllers
{
    public class HomeController : Controller
    {
        DatabaseFirstDbEntities2 db = new DatabaseFirstDbEntities2();

        public ActionResult Index()
        {
          
            return View();
        }
        //********************************************User Registration***********************************
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Register(User reg)
        {
            
            
                if (ModelState.IsValid)
            { 
                    db.Users.Add(reg);
             
               db.SaveChanges();
                ViewBag.SuccessMessage = "Registration Successful";

                //return RedirectToAction("Successful");
            }
           
            return View();
                
           
        }
        //************************************************ User Login************************************************
       
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]


        public ActionResult Login(User reg)
        {


            if (ModelState.IsValid)
            {
                var details = (from userlist in db.Users
                               where userlist.UserName == reg.UserName && userlist.UserPassword == reg.UserPassword
                               select new
                               {
                                   userlist.UserId,
                                   userlist.UserName
                               }).ToList();
                if (details.FirstOrDefault() != null)
                {
                    Session["UserId"] = details.FirstOrDefault().UserId;
                    Session["UserName"] = details.FirstOrDefault().UserName;
                    return RedirectToAction("Welcome");
                }

                else
                {
                    //ModelState.AddModelError("", "Invalid User Name or User Password");
                    ViewBag.message = "invalid username";
                }
            }
            return View(reg);
                


        }
            
        

        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Successful()
        {
            return View();
        }
        //Home
        public ActionResult Home()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //Courses
        public ActionResult Courses()
        {
           

            return View();
        }


    }
}