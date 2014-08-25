using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rs.Business;
using RS.Business.Managers;
using RS.Business.Managers.Contracts;

namespace RS.Presentation.MVC.Tests.BusinessManagers
{
    [TestClass]
    public  class ImageManagerTests
    {
        private IImageManager ImageManager { get; set; }

        public ImageManagerTests()
        {
            ImageManager = new ImageManager();
        }
        

        [TestMethod]
        public void Get_Images()
        {
            var images = ImageManager.Images;
            Assert.IsTrue(images.Any());
        }

        [TestMethod]
        public void Add_Image()
        {
            var image = new Image
            {
                Genre = new Genre
                {
                    Id = 3,
                    Name = "Ironic"
                },
                Title = "Test Img",
                ImageUrl = "http://isitfunny.com/content/pictures/bad_cat.jpeg",
                Description = "Weird Cat"
            };
            var addedImage = ImageManager.Add(image);
            Assert.IsTrue(addedImage.Id >0);
        }

        [TestMethod]
        public void Get_Images_By_Genre()
        {
         var images =   ImageManager.GetByGenre(2);
         Assert.IsTrue(images.Any());
        }

        [TestMethod]
        public void Delete_Image()
        {

            try
            {
                ImageManager.Delete(2);
            }
            catch (Exception)
            {

                Assert.Fail("Error");
            }

            Assert.IsNull(ImageManager.Get(2));

        }
    }
}
