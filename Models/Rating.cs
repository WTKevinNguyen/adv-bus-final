using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace adv_bus_final.Models
{
    public class Rating
    {
        public int RatingId {get; set;}

        public int RecipeId {get; set;}

        public int UserId {get; set;}
        [Required(ErrorMessage = "Rating value is required")]
        [Range(1, 5, ErrorMessage = "Rating value must be between 1 and 5")]
        public int RatingValue {get; set;}

        public Recipe Recipes {get; set;}



    }
}