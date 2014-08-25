using System.Collections.Generic;
using System.Linq;
using Rs.Business;
using RS.Business.Managers.Contracts;

namespace RS.Business.Managers
{
  public  class GenreManager:IGenreManager
    {
      public GenreManager()
      {
          Genres = new List<Genre>
          {
              new Genre
              {
                  Id = 1,
                  Name = "Fancy Cat"
              },
              new Genre
              {
                  Id=2,
                  Name = "Bad Cat"
              },
              new Genre
              {
                  Id = 3,
                  Name = "Ironic"
              },
              new Genre
              {
                  Id = 4,
                  Name ="Crazy"
              }

          }.AsEnumerable();
      }
      public IEnumerable<Genre> Genres { get; set; }
    }
}
