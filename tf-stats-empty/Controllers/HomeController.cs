using System.Web.Mvc;

namespace TFStats.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View("~/app/index.cshtml");
        }
    }
}