using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public string Category { get; set; }
        public int Servings { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public int TotalTime { get; set; }
        public string Source { get; set; }
        public string SourceURL { get; set; }

        public static List<Recipe> AllRecipes = new List<Recipe>();
        public Recipe(string name, List<string> ingredients, List<string> instructions, string category, int servings, int prepTime, int cookTime, int totalTime, string source, string sourceURL)
        {
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
            Category = category;
            Servings = servings;
            PrepTime = prepTime;
            CookTime = cookTime;
            TotalTime = totalTime;
            Source = source;
            SourceURL = sourceURL;
            AllRecipes.Add(this);
        }

        public static void InitializeRecipes()
        {
            AllRecipes.Add(new Recipe(
                "Spaghetti",
                new List<string> { "1 lb. spaghetti", "1 jar spaghetti sauce", "1 lb. ground beef" },
                new List<string> { "1. Boil water", "2. Brown beef", "3. Combine" },
                "Main Dish",
                4,
                10,
                20,
                30,
                "Mom",
                "http://www.mom.com/recipes/spaghetti"
                ));
            AllRecipes.Add(new Recipe(
                "Chocolate Chip Cookies",
                new List<string> { "2 1/4 cups flour", "1 tsp. baking soda", "1 cup butter", "3/4 cup sugar", "3/4 cup brown sugar", "1 tsp. vanilla", "2 eggs", "2 cups chocolate chips" },
                new List<string> { "1. Preheat oven to 375", "2. Mix dry ingredients", "3. Mix wet ingredients", "4. Combine", "5. Bake" },
                "Dessert",
                24,
                15,
                10,
                25,
                "Betty Crocker",
                "http://www.bettycrocker.com/recipes/chocolate-chip-cookies"
                ));

    }
}
