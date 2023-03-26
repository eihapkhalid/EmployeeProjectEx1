using Microsoft.AspNetCore.Mvc;
using EmployeeProjectEx.Models;
using EmployeeProjectEx.Bl;

namespace EmployeeProjectEx.Controllers
{
	public class EmployeesController : Controller
	{
        List<EmployeeModel> LstEmployees;
		 void CreateListEmployees() 
		{
            ClsEmployee oClsEmployee = new ClsEmployee();
            LstEmployees = oClsEmployee.GetData();
        }
		public IActionResult Create()
		{
			return View();
		}

		public IActionResult List()
		{

            CreateListEmployees();
            return View(LstEmployees);
		}

        public IActionResult Details(int id,string name)
        {
            CreateListEmployees();
            var myEmployees =LstEmployees.Where(a=>a.Id == id).FirstOrDefault();
            return View(myEmployees);
        }
    }
}
