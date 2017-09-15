using MMS.Models;
using MmsData;
using MmsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mms.Controllers
{
    public class DoctorSignUpController : Controller
    {
        MmsDBContext context = new MmsDBContext();
        // GET: DoctorSignUp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AccountCreate(DoctorModel model)
        {
            return View();
        }
    }
}