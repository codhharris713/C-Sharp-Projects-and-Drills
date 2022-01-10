using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Car Insurance";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Car Insurance";

            return View();
        }
    }
}