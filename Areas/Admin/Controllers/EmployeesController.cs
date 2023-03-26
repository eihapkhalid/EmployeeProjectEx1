using EmployeeProjectEx.Bl;
using Microsoft.AspNetCore.Mvc;
using EmployeeProjectEx.Models;

namespace EmployeeProjectEx.Areas.Admin.Controllers
{
    [Area("admin")]
    public class EmployeesController : Controller
    {
        public IActionResult List()
        {
            ClsEmployee oClsEmployee = new ClsEmployee();
            return View(oClsEmployee.GetData());
        }

        public IActionResult Edit()
        {
            return View(new EmployeeModel());
        }

        [AcceptVerbs("GET","POST")]
        public IActionResult VerfyEmail(string email) 
        {
            if (false)
            {
                return Json($"Email {email} is already in use.");
            }
            return Json(true);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(EmployeeModel employee)
        {
            if(!this.ModelState.IsValid) { View("Edit", employee); }
                  
            return View("Edit", employee);
        }
    }
}
