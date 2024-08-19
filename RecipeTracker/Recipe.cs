using RecipeTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

        public static Dictionary<string, Recipe> AllRecipes = new Dictionary<string, Recipe>();
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
        }

        public Recipe()
        {
        }
        public static Recipe GetRandomRecipe(Account loggedInAccount)
        {
            if (loggedInAccount.Recipes.Count == 0)
            {
                throw new InvalidOperationException("No recipes available for this account.");
            }

            Random random = new Random();
            int index = random.Next(loggedInAccount.Recipes.Count);
            return loggedInAccount.Recipes.ElementAt(index).Value;
        }
    }
}