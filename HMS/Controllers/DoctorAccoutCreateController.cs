﻿using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Controllers
{
    public class DoctorAccoutCreateController : Controller
    {
        // GET: DoctorAccoutCreate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DoctorSignUp(DoctorProfileModel model)
        {
            return View(model);
        }
    }
}