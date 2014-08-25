using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.Business.Contracts
{
    public abstract class IImage
    {
     public   int Id { get; set; }
     public string Title { get; set; }
     public string Description { get; set; }
     public string ImageUrl { get; set; }
     
     //public IGenre Genre { get; set; }
    }
}
