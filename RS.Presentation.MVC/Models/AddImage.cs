using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rs.Business;
using RS.Business.Contracts;

namespace RS.Presentation.MVC.Models
{
    public class AddImage:IImage
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
        public List<Genre> Genres { get; set; } 
    }
}