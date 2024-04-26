using Asp.net_intro_Homework.Models;
using Asp.net_intro_Homework.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_intro_Homework.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult Index()
		{
			var datas = GetAllEmployees();

			List<EmployeeVM> employees = new List<EmployeeVM>();

            foreach (var item in datas)
            {
				employees.Add(new EmployeeVM
				{
					Name = item.Name,
					Surname = item.Surname,
					Age = item.Age,
					Salary = item.Salary,
				});
                
            }

            return View(employees);
		}


		private List<Employee> GetAllEmployees()
		{
			return new List<Employee>
			{
				new()
				{
					Id = 1,
					Name = "Tasos Bakasetas",
					Salary = 5000,
					Age = 29
				},

				new()
				{
					Id = 2,
					Name = "Cakir Ugurcan",
					Salary = 7000,
					Age = 27
				},

				new()
				{
					Id = 3,
					Name = "Berat Ozdemir",
					Salary = 3200,
					Age = 25
				},
			};
		}
	}
}
