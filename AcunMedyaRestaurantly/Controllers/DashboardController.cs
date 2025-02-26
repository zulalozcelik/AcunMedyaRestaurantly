﻿using AcunMedyaRestaurantly.Context;
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
            ViewBag.Productcount = Db.Products.Count();
            ViewBag.CategoryCount = Db.Categories.Count();
            ViewBag.Chefcount = Db.Chefs.Count();
            ViewBag.SpecialCount = Db.Contacts.Count();
            return View();
        }
        public PartialViewResult ReservasionPartial()
        {
            var values = Db.Reservations.ToList();
            return PartialView(values);
        }
    }
}