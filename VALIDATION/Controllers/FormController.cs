using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VALIDATION.Models;

namespace VALIDATION.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Form form)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Form = form.Name;
            return View(form);
        }
    }
}