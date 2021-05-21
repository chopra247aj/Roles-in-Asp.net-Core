using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string BoxOffice { get; set; }

        [Required]
        [Display(Name = "Is Movie Active?")]
        public bool Active { get; set; }

        [Display(Name = "Date of Launch")]
        public DateTime DateOfLaunch { get; set; }

        [Required]
        public string Genre { get; set; }

        [Display(Name = "Movie Has Teaser?")]
        public bool HasTeaser { get; set; }

    }
}
