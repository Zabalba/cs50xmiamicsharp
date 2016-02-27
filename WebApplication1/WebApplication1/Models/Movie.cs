using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        

        [Display(Name = "Year Released")]
        public string ReleaseYear { get; set; }



    }
}
