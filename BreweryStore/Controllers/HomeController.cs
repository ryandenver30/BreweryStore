using BreweryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BreweryStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult BreweryJS()
        {
            return View();
        }

        public JsonResult GetBrewery(string key)
        {
            Brewery weath = new Brewery();
            return Json(weath.getAutoCompleteData(key), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBreweryByName(string key)
        {
            Brewery weath = new Brewery();
            return Json(weath.getBreweryByName(key), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getBreweryByState(string key)
        {
            Brewery weath = new Brewery();
            return Json(weath.getBreweryByState(key), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getBreweryByNameAndState(string name,string stateName)
        {
            Brewery weath = new Brewery();
            return Json(weath.getBreweryByNameAndState(name,stateName), JsonRequestBehavior.AllowGet);
        }
    }
}