using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppDemo.Models;
using DataLibrary;
using DataLibrary.BusinessLogic; //amycn1 add DataLibrary
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace MVCAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employees List";

            var data = LoadEmployees(); //calling the Employees model

            //FOR EACH loop HERE
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {

                    EmployeeId = row.EmployeeId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    ConfirmEmail = row.EmailAddress
                });

            }

            return View(employees);

        }




        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //amycn1 create a new actionresult

        public ActionResult SignUp()
        {
            ViewBag.Message = "Emplyee Sign Up";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //validate the SignUp.cshtml with the AntiForgeryToken
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreate = CreateEmployee(model.EmployeeId,
                    model.FirstName,
                    model.LastName,
                    model.EmailAddress);


                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
