using Asp.net_intro_Homework.Models;
using Asp.net_intro_Homework.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_intro_Homework.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			var datas = GetAllProducts();

			List<ProductVM> products = new List<ProductVM>();

            foreach (var item in datas)
            {
				products.Add(new ProductVM
				{
					Name = item.Name,
					Price = item.Price,
					Count = item.Count,
					Description = item.Description,
				});
            }

            return View(products);
		}


		private List<Product> GetAllProducts()
		{
			return new List<Product>
			{
				new()
				{
					Id = 1,
					Name = "Phone",
					Price = 2000,
					Count = 5,
					Description = "test1"
				},

				new()
				{
					Id = 2,
					Name = "Television",
					Price = 4000,
					Count = 8,
					Description = "test2"
				},

				new()
				{
					Id = 3,
					Name = "Watch",
					Price = 1800,
					Count = 3,
					Description = "test3"
				},
			};
		}
	}
}
