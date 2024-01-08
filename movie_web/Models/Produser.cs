using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie_web.Models
{
    public class Produser
    {
        [Key]
        public int ProduserID { get; set; }
        public string fullName { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureUrl { get; set; }
        
        public List<Movie> Movies { get; set; }
    }
}
