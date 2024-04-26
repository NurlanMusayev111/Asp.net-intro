using Asp.net_intro.Models;
using Asp.net_intro.ViewModels;
using Asp.net_intro.ViewModels.Student;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_intro.Controllers
{	
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			var datas = GetAllStudents();

			List<StudentVM> students = new List<StudentVM>();

            foreach (var item in students)
            {
				students.Add(new StudentVM
				{
					FullName = item.FullName
				});
            }

			Book book = new()
			{
				Id = 1,
				Name = "Yeddi Gozel"
			};


			HomeVM models = new()
			{
				Students = students,
				Book = book
			};

            return View(datas);
        }


        private List<Student> GetAllStudents()
        {
			return new List<Student>
			{
				new()
				{
					Id = 1,
					FullName = "Nurlan Musayev",
					Age = 22
				},

				new()
				{
					Id = 2,
					FullName = "Nermin Memmedova",
					Age = 30
				},

				new()
				{
					Id = 3,
					FullName = "Gunel Veliyeva",
					Age = 32
				}
			};

		}
    }
}
