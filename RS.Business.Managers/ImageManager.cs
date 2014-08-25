using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;
using Rs.Business;
using RS.Business.Contracts;
using RS.Business.Managers.Contracts;

namespace RS.Business.Managers
{
    public class ImageManager : IImageManager
    {
       

       
        public ISimpleDataStore DataStore { get; set; }

        public IEnumerable<Image> Images
        {
            get { return DataStore.Images; }
            set { DataStore.Images = value.ToList(); }
        }

       

        public IEnumerable<Image> GetByGenre(int genreId)
        {
           return DataStore.Images.Where(i => i.Genre.Id == genreId);
        }

        public Image Get(int id)
        {
            return DataStore.Images.FirstOrDefault(I => I.Id == id);
        }

        public Image Add(Image newImage)
        {
            
            newImage.Id = DataStore.Images.Max(r => r.Id)+1;
            DataStore.Images.Add(newImage);
            DataStore.SaveChanges();
            
            return newImage;
        }

        public void Delete(int  imageId)
        {
            var image = Get(imageId);
            DataStore.Images.Remove(image);
            DataStore.SaveChanges();
        }
    }
}
