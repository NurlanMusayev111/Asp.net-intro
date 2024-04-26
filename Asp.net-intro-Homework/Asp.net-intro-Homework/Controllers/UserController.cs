using Asp.net_intro_Homework.Models;
using Asp.net_intro_Homework.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_intro_Homework.Controllers
{
	public class UserController : Controller
	{

			
		public IActionResult Index()
		{

			var datas = GetAllUsers();

			List<UserVM> users = new List<UserVM>();

            foreach (var item in datas)
            {
				users.Add(new UserVM
				{
					FullName = item.FullName,
					Address = item.Address,
					Email = item.Email,
					Age = item.Age,
				});
            }

            return View(users);




		}

		private List<User> GetAllUsers()
		{
			return new List<User>
			{
				new()
				{
					Id = 1,
					FullName = "Nurlan Musayev",
					Address = "Narimanov",
					Email = "nm@mail.ru",
					Age = 22
				},

				new()
				{
					Id = 2,
					FullName = "Kenan Elekberli",
					Address = "Bilacari",
					Email = "ke935@mail.ru",
					Age = 21
				},

				new()
				{
					Id = 3,
					FullName = "Nuru Aliyev",
					Address = "Zabrat",
					Email = "nr579@mail.ru",
					Age = 28
				}
			};
		}

	}
}
