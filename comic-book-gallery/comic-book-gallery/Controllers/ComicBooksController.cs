using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comic_book_gallery.Controllers //does this mark the url or is the class below what determines that - Can I change this name?
{
    public class ComicBooksController : Controller //As mentioned above, does this mark the url path?
    {
        public ActionResult Detail()  //Can I put as many actionresults as I want to make different pages? - Also what about extending the url further?
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
