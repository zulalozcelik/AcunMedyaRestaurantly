﻿using AcunMedyaRestaurantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaRestaurantly.Controllers
{
    [Authorize]
    public class StatisticController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();

        public ActionResult Index()
        {
            ViewBag.CategoryCount = Db.Categories.Count();
            ViewBag.ChefCount = Db.Chefs.Count();
            ViewBag.EventCount = Db.Events.Count();
            ViewBag.GalleryCount = Db.Galleries.Count();
            ViewBag.ProductCount = Db.Products.Count();
            ViewBag.ReservationCount = Db.Reservations.Count();
            ViewBag.ServiceCount = Db.Services.Count();
            ViewBag.SpecialCount = Db.Specials.Count();
            ViewBag.TestimonialCount = Db.Testimonials.Count();
            ViewBag.MessageCount = Db.Contacts.Count();
            ViewBag.NotificationCount = Db.Notifications.Count();
            ViewBag.AdminCount = Db.Admins.Count();
            return View();
        }

    }
}