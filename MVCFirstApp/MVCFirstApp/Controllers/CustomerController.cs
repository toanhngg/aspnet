using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return RedirectToAction("GetAllCustomer", "Customer");
        }
        public string GetAllCustomer()
        {
            return @"<ul>
                        <li>To</li>
                        <li>Anh</li> 
                        <li>Ne</li>
                        <li>Hi hi</li>
                    </ul>";
        }
    }
}