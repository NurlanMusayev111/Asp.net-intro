using Asp.net_intro_Homework.Models;
using Asp.net_intro_Homework.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_intro_Homework.Controllers
{
	public class BookController : Controller
	{
		public IActionResult Index()
		{

			var datas = GetAllBooks();

			List<BookVM> books = new List<BookVM>();

			foreach (var data in datas)
			{
				books.Add(new BookVM
				{
					Name = data.Name,
				});
			}

			return View(books);
		}



		private List<Book> GetAllBooks()
		{
			return new List<Book>
			{
				new()
				{
					Id = 1,
					Name = "Yeddi Gozel"
				},
				new()
				{
					Id = 2,
					Name = "Sultan Suleyman"
				}
			};
		}
	}
}
