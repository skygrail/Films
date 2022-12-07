using System;
using System.ComponentModel.DataAnnotations;

namespace Films.Models
{
    public class Film
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string FilmName { get; set; }

        [Required]
        public string Video { get; set; }

        [Required]
        public string Poster { get; set; }

        public string Time { get; set; }

        public string DateRelease { get; set; }

        public Contries CountryRelease { get; set; }

        public int Rating { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string Director { get; set; }

        public Categoryies Category { get; set; }

        public Companies Company { get; set; }
    }
}
