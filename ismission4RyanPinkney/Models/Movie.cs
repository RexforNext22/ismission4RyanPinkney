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
        public string sYear { get; set; }

        // Movie director
        [Required]
        public string sDirector { get; set; }

        // Movie category
        [Required]
        public string sCategory { get; set; }

        // Movie rating
        [Required]
        public string sRating { get; set; }

        // Movie edited (I made this field a string to get the data validation to work correctly with Sqlite)
        // Professor Hilton told me to make this a required fieild so it would work with sqlite
        [Required]
        public bool bIsEdited { get; set; }

        // Movie lent to
        public string sLentToName { get; set; }

        // Movie notes
        public string sNotes { get; set; }





    }
}
