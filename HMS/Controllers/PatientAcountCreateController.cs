﻿using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Controllers
{
    public class PatientAcountCreateController : Controller
    {
        // GET: PatientAcountCreate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PatientSignUp(PatientProfileModel model)
        {
            return View(model);
        }
    }
}