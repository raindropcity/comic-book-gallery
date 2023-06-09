using comicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace comicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public string Detail()
        {
            return "Hello(from ComicBookController)";
        }
    }
}