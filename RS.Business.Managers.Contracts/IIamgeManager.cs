using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rs.Business;
using RS.Business.Contracts;

namespace RS.Business.Managers.Contracts
{
    public interface IImageManager
    {
        IEnumerable<Image> Images { get; set; }
        IEnumerable<Image> GetByGenre(int genreId);
        Image Get(int imageId);
        Image Add(Image image);
        void Delete(int imageId);
    }
}
