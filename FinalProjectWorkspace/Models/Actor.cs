using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class Actor
    {
        public Int32 ActorID { get; set; }

        public String ActorName { get; set; }

        public List<Movie> Movies { get; set; }

        public Actor()
        {
            if (Movies == null)
            {
                Movies = new List<Movie>();
            }
        }
    }
}
