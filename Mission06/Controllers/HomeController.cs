using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext daContext { get; set; }

        //contstructor
        public HomeController( MovieApplicationContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else //not valid
            {
                ViewBag.Categories = daContext.Categories.ToList();

                return View(ar);
            }

        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            var applicatons = daContext.responses.Include(x => x.Category).ToList();

            return View(applicatons);
        }

        public IActionResult Edit (int id)
        {

            ViewBag.Categories = daContext.Categories.ToList();

            var application = daContext.responses.Single(x => x.applicationID == id);

            return View("EnterMovie", application);

        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete (int id)
        {
            var application = daContext.responses.Single(x => x.applicationID == id);
            return View(application);

        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.responses.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("MovieList");

        }


    }
}
