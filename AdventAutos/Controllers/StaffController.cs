using AdventModels.ResponseFields;
using DataLibrary.BusinessLogic;
using DataLibrary.ResponseFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventAutos.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            var listStaff = StaffFactory.LoadUsers();

            List<StaffResponse> staffList = new List<StaffResponse>();
            foreach (var item in listStaff)
            {
                StaffResponse val = new StaffResponse()
                {
                    EmployeeID = item.EmployeeID,
                    EmployeeName = item.EmployeeName,
                    EmployeeSurname = item.EmployeeSurname,
                    Username = item.Username,
                    Role = item.Role
                };

                staffList.Add(val);
            }

            StaffPage sp = new StaffPage();
            sp.StaffResponses = staffList;

            return View(sp);
        }

        public ActionResult Create()
        {
            AdventAuto.Models.Staff staff = new AdventAuto.Models.Staff()
            {
                EmployeeID = 0,
                EmployeeName = "",
                EmployeeSurname = "",
                Role = "",
                Username = ""
            };

            return View(staff);
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}