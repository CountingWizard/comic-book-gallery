﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "Hello World"
            };
        }

    }
}
