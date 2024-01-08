using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie_web.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaID { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
