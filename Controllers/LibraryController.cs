using Microsoft.AspNetCore.Mvc;

namespace CheckList.Controllers
{
    public class LibraryController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            return View();
        }
    }
}
