using AcunMedyaRestaurantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaRestaurantly.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();

        // GET: Dahboard
        public ActionResult Index()
        {
            ViewBag.ProductCount = Db.Products.Count();
            ViewBag.CategoryCount = Db.Categories.Count();
            ViewBag.ChefCount = Db.Chefs.Count();
            ViewBag.SpecialCount = Db.Specials.Count();
            //ViewBag.MessageCount = Db.Contacts.Count();
            //ViewBag.NotificationCount = Db.Notifications.Count();
            //ViewBag.ReservationCount = Db.Reservations.Count();
            //ViewBag.TestimonialCount = Db.Testimonials.Count();
            return View();
        }
        public PartialViewResult ReservasionPartial()
        {
            var values = Db.Reservations.ToList();
            return PartialView(values);
        }
    }
}