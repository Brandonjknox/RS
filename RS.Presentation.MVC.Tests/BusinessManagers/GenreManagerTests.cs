using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.Business.Managers;
using RS.Business.Managers.Contracts;

namespace RS.Presentation.MVC.Tests.BusinessManagers
{
    [TestClass]
   public class GenreManagerTests
    {
        public GenreManagerTests()
        {
            GenreManager = new GenreManager();
        }
        public IGenreManager GenreManager { get; set; }
        [TestMethod]
        public void Get_Genres()
        {
            var genres = GenreManager.Genres;
            Assert.IsTrue(genres.Any());
        }
    }
}
