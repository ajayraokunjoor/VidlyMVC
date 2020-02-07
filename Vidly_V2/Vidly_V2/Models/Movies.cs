using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_V2.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
    }
}