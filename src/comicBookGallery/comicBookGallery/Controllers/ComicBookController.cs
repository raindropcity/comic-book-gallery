using comicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace comicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            return View();
        }
    }
}

// RedirectResult class is another action result that MVC provide. Used to redirect user another URL