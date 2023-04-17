using Microsoft.AspNetCore.Mvc;

namespace Helloworld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GotoHome()
        {
            return View();
        }
    }
}
