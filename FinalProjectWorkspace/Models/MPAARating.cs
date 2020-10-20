using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class MPAARating
    {
        public Int32 MPAARatingID { get; set; }

        public String MPAARatingNamee { get; set; }

        public List<Movie> Movies { get; set; }

        public MPAARating()
        {
            if (Movies == null)
            {
                Movies = new List<Movie>();
            }
        }
    }
}
