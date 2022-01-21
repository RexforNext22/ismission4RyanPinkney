using System;
using System.ComponentModel.DataAnnotations;

namespace ismission4RyanPinkney.Models
{
    public class Movie
    {

        // Primary key for the database
        [Key]
        [Required]
        public int movie_id { get; set; }


        // Movie title
        [Required]
        public string sTitle { get; set; }

        // Movie year
        [Required]
        public int iYear { get; set; }

        // Movie director
        [Required]
        public string sDirector { get; set; }

        // Movie category
        [Required]
        public string sCategory { get; set; }

        // Movie rating
        [Required]
        public string sRating { get; set; }

        // Movie edited
        [Required]
        public bool bIsEdited { get; set; }

        // Movie lent to
        [Required]
        public string sLentToName { get; set; }

        // Movie title
        [Required]
        public string sNotes { get; set; }





    }
}
