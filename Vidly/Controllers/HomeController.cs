using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult TableShow() 
        //{
        //    ViewBag.Message = "Show of all videos";

        //    return View();
          
        //}

        //public ActionResult Create() 
        //{
        //    ViewBag.Message = "Create new link to a video";

        //    return View();
        
        
        //}

    }
}