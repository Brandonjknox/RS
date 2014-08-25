using System;
using System.Linq;
using System.Web.Mvc;
using Rs.Business;
using RS.Business.Managers.Contracts;
using RS.Presentation.MVC.Models;

namespace RS.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IImageManager ImageManager { get; set; }
        public IGenreManager GenreManager { get; set; }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View((Image) ImageManager.Get(id));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new AddImage {Genres = GenreManager.Genres.ToList()});
        }

        [HttpPost]
        public ActionResult Create(AddImage addImage)
        {
            addImage.Genres = GenreManager.Genres.ToList();
            if (ModelState.IsValid)
            {
                addImage.Genre = (Genre)GenreManager.Genres.FirstOrDefault(r => r.Id == addImage.GenreId);
                try
                {
                    var newImage = new Image()
                    {
                        Description = addImage.Description,
                        ImageUrl = addImage.ImageUrl,
                        Title = addImage.Title,
                        Genre = addImage.Genre
                    };
                    ImageManager.Add(newImage);
                return View("Index",ImageManager.Images);
                }
                catch (Exception ex)
                {
                    
                    ModelState.AddModelError(string.Empty,ex.Message);
                }
            }
            return View(addImage);
        }

    }
}
