using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MVCFirstApp.Controllers
{
    public class CurrentTimeController : Controller
    {
        // GET: Current
        public ActionResult Index()
        {
            var input = DateTime.Now.ToString();
            return Content(input);
           
        }
    }
}