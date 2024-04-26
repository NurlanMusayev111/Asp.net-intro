using Microsoft.AspNetCore.Mvc;

namespace Asp.net_intro.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
