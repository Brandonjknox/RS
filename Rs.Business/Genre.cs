using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.Business.Contracts;

namespace Rs.Business
{
   public class Genre: IGenre
    {
       public int Id { get; set; }
       public string Name { get; set; }
    }
}
