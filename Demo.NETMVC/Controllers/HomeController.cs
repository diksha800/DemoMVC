using ClassDemo.Services;
using System.Data.Entity;
using System.Web.Mvc;


namespace Demo.NETMVC.Controllers
{
    public class HomeController : Controller
    {
        IrestaurantData db;
        public HomeController(IrestaurantData db)
        {
            this.db = db;
        }


        public ActionResult Index()
        {
            var model = db.GetAll();

            return View(model);
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
    }
}