﻿using AcunMedyaRestaurantly.Context;
using AcunMedyaRestaurantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaRestaurantly.Controllers
{
    [Authorize]
    public class EventController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();

        public ActionResult Index()
        {
            var value = Db.Events.ToList();
            return View(value);
        }
        public ActionResult EventList()
        {
            var value = Db.Events.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult EventCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EventCreate(Event model)
        {
            Db.Events.Add(model);
            Db.SaveChanges();
            return RedirectToAction("EventList");
        }
        [HttpGet]
        public ActionResult EventEdit(int id)
        {
            var value = Db.Events.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EventEdit(Event model)
        {
            var value = Db.Events.Find(model.EventId);
            value.Title = model.Title;
            value.Price = model.Price;
            value.Description4 = model.Description4;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.Description3 = model.Description3;
            value.Description4 = model.Description4;

            value.ImageUrl = model.ImageUrl;
            Db.SaveChanges();
            return RedirectToAction("EventList");
        }
        public ActionResult EventDelete(int id)
        {
            var value = Db.Events.Find(id);
            Db.Events.Remove(value);
            Db.SaveChanges();
            return RedirectToAction("EventList");
        }
    }
}