using ComicBookGallery.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Witness <strong>the Doctor Octopus'</strong> revenge!</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Script", Role = "Dan Slott" },
                    new Artist() { Name = "Pencils", Role = "Humberto Ramos" },
                    new Artist() { Name = "Inks", Role = "Victor Olazaba" },
                    new Artist() { Name = "Colors", Role = "Edgar Delgado" },
                    new Artist() { Name = "Letters", Role = "Chris Eliopoulos" },
                }
            };

            return View(comicBook);
        }
    }
}

// RedirectResult class is another action result that MVC provide. Used to redirect user another URL