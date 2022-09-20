using ClassDemo.Models;
using ClassDemo.Services;
using System.Web.Mvc;

namespace Demo.NETMVC.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IrestaurantData db;

        public RestaurantController(IrestaurantData db)
        {
            this.db = db;

        }
        // GET: Restaurant
        public ActionResult Index()
        {
            var model = db.GetAll();

            return View(model);
        }
        
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurants)
        {
            //if(string.IsNullOrEmpty(restaurants.Name))
            //{
            //    ModelState.AddModelError(nameof(restaurants.Name), "Name is required");
            //}
            if (ModelState.IsValid)
            {
                db.add(restaurants);
                return RedirectToAction("Details", new { id = restaurants.ID});

            }
            return View(restaurants);

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            {
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }
        }
        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            if(ModelState.IsValid)
            {
                db.Update(restaurant);
                TempData["Message"] = "You have Saved Change..";
                return RedirectToAction("Details", new { id = restaurant.ID });
            }
            return View(restaurant);
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var model = db.Get(ID);
            if(model==null)
            {
                return View("Not found");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
        
}