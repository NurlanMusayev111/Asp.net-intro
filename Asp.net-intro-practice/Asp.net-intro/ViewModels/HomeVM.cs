
using Asp.net_intro.Models;
using Asp.net_intro.ViewModels.Student;

namespace Asp.net_intro.ViewModels
{
	public class HomeVM
	{
		public List<StudentVM> Students { get; set; }
		public Book Book { get; set; }
	}
}
