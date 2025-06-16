using Microsoft.AspNetCore.Mvc;

namespace BB_NayiDisha_New.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

    }
}
