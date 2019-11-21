using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace wooliesx.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
