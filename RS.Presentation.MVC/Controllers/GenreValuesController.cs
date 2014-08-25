using System.Collections.Generic;
using System.Web.Http;
using RS.Business.Contracts;
using RS.Business.Managers.Contracts;

namespace RS.Presentation.MVC.Controllers
{
    public class GenreValuesController : ApiController
    {
        public IGenreManager GenreManager { get; set; }

        public IEnumerable<IGenre> Get()
        {
            return GenreManager.Genres;
        }
    }
}
