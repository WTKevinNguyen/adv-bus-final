using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace adv_bus_final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Recipes.Any() || context.Ratings.Any())
                {
                    return;
                }

                var recipes = new List<Recipe>
                {
                    new Recipe
                    {
                        RecipeId = 1,
                        Title = "Chocolate Chip Cookies",
                        Description = "Delicious classic cookies with melted chocolate chips",
                        Ingrediants = "Flour, sugar, eggs, butter, chocolate chips",
                        Instructions = "Cream butter and sugar, add eggs, mix in dry ingredients, fold in chocolate chips, bake for 10-12 minutes at 375°F",
                        Length = "30 min",
                        UserId = 1
                    },

                    new Recipe
                    {
                        RecipeId = 2,
                        Title = "Spicy Chicken Curry",
                        Description = "A flavorful curry with tender chicken and vegetables",
                        Ingrediants = "Chicken breasts, potatoes, carrots, curry powder, coconut milk",
                        Instructions = "Sauté onions and spices, add chicken and cook until golden brown, add vegetables and coconut milk, simmer until chicken is cooked through",
                        Length = "45 min",
                        UserId = 2
                    },
                    new Recipe
                    {
                        RecipeId = 3,
                        Title = "Italian Pasta Salad",
                        Description = "Cold pasta salad with vegetables and a vinaigrette dressing",
                        Ingrediants = "Rotini pasta, cherry tomatoes, cucumbers, red onion, olives, Italian dressing",
                        Instructions = "Cook pasta according to package directions, toss with vegetables and dressing, chill for at least 2 hours",
                        Length = "1 hour",
                        UserId = 3
                    },
                    new Recipe
                    {
                        RecipeId = 4,
                        Title = "Vegetarian Chili",
                        Description = "A hearty chili with beans, vegetables, and spices",
                        Ingrediants = "Kidney beans, black beans, corn, tomatoes, green peppers, chili powder, cumin",
                        Instructions = "Sauté onions and peppers, add spices and beans, stir in corn and tomatoes, simmer until thickened",
                        Length = "1 hour",
                        UserId = 4
                    },
                    new Recipe
                    {
                        RecipeId = 5,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 6,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 7,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 8,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 9,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 10,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 11,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    new Recipe
                    {
                        RecipeId = 12,
                        Title = "Food",
                        Description = "Yum",
                        Ingrediants = "Egg",
                        Instructions = "Eat",
                        Length = "Short",
                        UserId = 1
                    },
                    
                };
                

                context.Recipes.AddRange(recipes);
                context.SaveChanges();

                var ratings = new List<Rating>
                {
                    new Rating
                    {
                        RatingId = 1,
                        RecipeId = 1,
                        UserId = 1,
                        RatingValue = 5,
                    },
                    new Rating
                    {
                        RatingId = 2,
                        RecipeId = 1,
                        UserId = 2,
                        RatingValue = 4,
                    },
                    new Rating
                    {
                        RatingId = 3,
                        RecipeId = 2,
                        UserId = 2,
                        RatingValue = 5,
                    },
                    new Rating
                    {
                        RatingId = 4,
                        RecipeId = 3,
                        UserId = 3,
                        RatingValue = 4,
                    },
                    new Rating
                    {
                        RatingId = 5,
                        RecipeId = 4,
                        UserId = 4,
                        RatingValue = 3,
                    }
                };

            context.Ratings.AddRange(ratings);
            context.SaveChanges();


            }
        }
    }
}
