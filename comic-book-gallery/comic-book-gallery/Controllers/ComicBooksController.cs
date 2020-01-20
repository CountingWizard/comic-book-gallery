using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            /*
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");
            }

            return Content("Hello World");
            */

            ViewBag.SeriesTitle = "Outsiders";
            ViewBag.IssueNumber = 101;
            ViewBag.Description = "<p>Final Issue of Outsiders for sale now!</p>";
            ViewBag.Artists = new string[]
            {
                "Writing: Smart Guy 1",
                "Writing: Smart Guy 2",
                "Cover: Smart Guy 3"
            };

            return View();
        }

    }
}
