using comic_book_gallery.Models;
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
            var comicBook = new ComicBook()
            {
                //Set values here or outside by calling ComicBook.VarName
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final Issue of Outsiders for sale now!</p>",
                Artists = new Models.Artist[]
                {
                    new Models.Artist() { Name = "Smart Guy 1", Role = "Writing" },
                    new Models.Artist() { Name = "Smart Guy 2", Role = "Drawing" },
                    new Models.Artist() { Name = "Smart Guy 3", Role = "Editing" },
                }
            };


            /*
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");
            }

            return Content("Hello World");

            ViewBag.SeriesTitle = "Outsiders";
            ViewBag.IssueNumber = 101;
            ViewBag.Description = "<p>Final Issue of Outsiders for sale now!</p>";
            ViewBag.Artists = new string[]
            {
                "Writing: Smart Guy 1",
                "Writing: Smart Guy 2",
                "Cover: Smart Guy 3"
            };
            */

            return View(comicBook);
        }

    }
}
