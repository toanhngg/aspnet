using MVCFirstApp.ActionFilters;
using MVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 15)]
        public ActionResult Index()
        {
            //return "hiii";
            return View();
        }
        //[OutputCache(Duration = 10)]
        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return TimeString();
        }
        public string MyController()
        {
            return "Hi, I am Controller";

        } 
        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T"); 
        }
        public ActionResult MyView()
        {
            return View();
        }
        public ActionResult TimeSheet() {
            return View();
        }


        public ActionResult Register()
        {
            return View();

        }


        [HttpPost]

        public ActionResult Register(Customer model)
        {
            if (model.Attends == "yes")
            {
                //ViewBag.Result = ThankYes(); // truyền kết quả vào biến ViewBag
                //return View();
                string result = ThankYes();
                return Content(result);

                // Do something if Yes is selected
            }
            else if (model.Attends == "no")
            {
                // Do something if No is selected
                string result2 = ThankNo();
                return Content(result2);
            }
            return View(model);
        }
        [NonAction]
        public string ThankNo()
        {
            return @"<h2>Thanks for your response</h2>
                        <p>Sorry to hear that you can't make it, but thanks for letting us know</p>";
        }
        [NonAction]
        public string ThankYes()
        {
            return @"<h2>Thanks for your response</h2>
                        <p>It's great that you're coming.Let's choose your game </p>";
        }

    }
}