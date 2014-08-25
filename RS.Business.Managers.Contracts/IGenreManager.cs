using System.Collections.Generic;
using Rs.Business;

namespace RS.Business.Managers.Contracts
{
    public interface IGenreManager
    {
        IEnumerable<Genre> Genres { get; set; }
    }
}
