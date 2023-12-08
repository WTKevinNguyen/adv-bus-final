using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
namespace adv_bus_final.Models
{
    public class Recipe
    {
        public int RecipeId {get; set;}

        [Required(ErrorMessage = "Title is required")]
        public string Title {get; set;}
        [Required(ErrorMessage = "Description is required")]

        public string Description {get; set;}
        [Required(ErrorMessage = "Ingredients are required")]

        public string Ingrediants {get; set;}
        [Required(ErrorMessage = "Instructions are required")]
        

        public string Instructions {get; set;}
        [Required(ErrorMessage = "Length is required")]

        public string Length {get; set;}

        public int UserId {get; set;}

        public Recipe Recipes {get; set;}

        public List<Rating> Ratings {get; set;}
 

    }
}