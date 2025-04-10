using AcunMedyaRestaurantly.Context;
using AcunMedyaRestaurantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaRestaurantly.Controllers
{
    public class DefaultController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialTop()
        {
            ViewBag.Call = Db.Adresses.Select(x => x.Call).FirstOrDefault();
            ViewBag.OpenHours = Db.Adresses.Select(x => x.OpenHours).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            ViewBag.SubTitle = Db.Features.Select(x => x.SubTitle).FirstOrDefault();
            ViewBag.Title = Db.Features.Select(x => x.Title).FirstOrDefault();
            ViewBag.VideoUrl = Db.Features.Select(x => x.VideoUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.Title = Db.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.Description = Db.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.ImageUrl = Db.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            var value = Db.Services.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialMenu()
        {
            var value = Db.Products.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult ContactAdd(Contact model)
        {
            model.SendDate = DateTime.Now;
            model.IsRead = false;
            Db.Contacts.Add(model);
            Db.SaveChanges();
            ViewBag.Message = "Mesaj Başarılı";
            return View("Index");

        }
        public PartialViewResult PartialSpecial()
        {
            var value = Db.Specials.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialBookaTable()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult BookTableAdd(Reservation model)
        {
            model.ReservationStatus = "Onay Bekliyor";
            Db.Reservations.Add(model);
            Db.SaveChanges();
            ViewBag.Message = "Rezervasyon Başvurusu Başarılı";
            return View("Index");

        }
        public PartialViewResult PartialTestimonial()
        {
            var value = Db.Testimonials.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialChef()
        {
            var value = Db.Chefs.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialAdress()
        {
            ViewBag.Location = Db.Adresses.Select(x => x.Location).FirstOrDefault();
            ViewBag.OpenHours = Db.Adresses.Select(x => x.OpenHours).FirstOrDefault();
            ViewBag.Email = Db.Adresses.Select(x => x.Email).FirstOrDefault();
            ViewBag.Call = Db.Adresses.Select(x => x.Call).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialEvent()
        {
            var value = Db.Events.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialGallery()
        {
            var value = Db.Galleries.ToList();
            return PartialView(value);
        }


    }
}