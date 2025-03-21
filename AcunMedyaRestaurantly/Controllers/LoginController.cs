﻿using AcunMedyaRestaurantly.Context;
using AcunMedyaRestaurantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AcunMedyaRestaurantly.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();
        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values = Db.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, true);
                Session["a"] = values.UserName;
                Session["id"] = values.AdminId;
                Session["surname"] = values.SurName;
                Session["name"] = values.Name;
                Session["img"] = values.ImageUrl;
                Session["Email"] = values.Email.ToString();
                Session["Password"] = values.Password.ToString();
                return RedirectToAction("Index", "Profiles");
            }
            return View();
        }
    }
}