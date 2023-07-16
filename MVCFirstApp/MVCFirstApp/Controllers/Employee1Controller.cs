﻿using MVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class Employee1Controller : Controller
    {
        // GET: Employee1
        public ActionResult Index()
        {
            var employees = from e in empList
                            orderby e.ID
                            select e;
            return View(employees);

        }

        // GET: Employee1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee1/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                empList.Add(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Employee1/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = empList.Single(m => m.ID == id);
            return View(employee);
        }


        // POST: Employee1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {

                // TODO: Add update logic here
                var employee = empList.Single(m => m.ID == id);
                if (TryUpdateModel(employee))
                {
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public static List<Employee> empList = new List<Employee> {
              new Employee{
         ID = 1,
         Name = "Allan",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 23
      },

      new Employee{
         ID = 2,
         Name = "Carson",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 45
      },

      new Employee{
         ID = 3,
         Name = "Carson",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 37
      },

      new Employee{
         ID = 4,
         Name = "Laura",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 26
      },
   };
    }
}

   
