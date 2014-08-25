using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.Business.Contracts
{
   public abstract class IGenre
    {
       public int Id { get; set; }
       public string Name { get; set; }
    }
}
