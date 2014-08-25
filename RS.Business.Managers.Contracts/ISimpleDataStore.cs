using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Rs.Business;
using RS.Business.Contracts;

namespace RS.Business.Managers.Contracts
{
    public interface ISimpleDataStore
    {
       List<Image> Images { get; set; }
        List<IGenre> Genres { get; set; }

        void SaveChanges();

    }
}
