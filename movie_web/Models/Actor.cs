using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie_web.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string ProfilePictueUrl { get; set; }
       
        
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
