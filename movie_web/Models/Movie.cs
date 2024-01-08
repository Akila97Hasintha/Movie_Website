using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace movie_web.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCatagory MovieCatagory { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }
        public int ProduserID { get; set; }
        [ForeignKey("ProduserID")]
        public Produser Produser { get; set; }
    }
}
