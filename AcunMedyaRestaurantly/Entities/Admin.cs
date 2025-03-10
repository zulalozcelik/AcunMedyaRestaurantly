﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcunMedyaRestaurantly.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        [NotMapped]
        public string CurrentPasword { get; set; }

        [NotMapped]
        public string NewPasword { get; set; }

        [NotMapped]
        public string ConfirmPasword { get; set; }

    }
}