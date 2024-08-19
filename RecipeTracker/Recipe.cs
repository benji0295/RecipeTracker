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
        }

        public Recipe()
        {
        }
        public static Recipe GetRandomRecipe()
        {
            if (AllRecipes.Count == 0)
            {
                InitializeRecipes();
            }

            Random random = new Random();
            int index = random.Next(AllRecipes.Count);
            return AllRecipes[index];
        }

        public static void InitializeRecipes()
        {
            AllRecipes.Clear();

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
                "Chicken Parmesan",
                new List<string> { "2 chicken breasts", "1 cup marinara sauce", "1 cup mozzarella cheese" },
                new List<string> { "1. Bread the chicken", "2. Fry chicken", "3. Top with sauce and cheese", "4. Bake until golden" },
                "Main Dish",
                2,
                15,
                25,
                40,
                "Grandma",
                "http://www.grandma.com/recipes/chicken-parmesan"
            ));

            AllRecipes.Add(new Recipe(
                "Beef Stew",
                new List<string> { "2 lbs. beef", "4 carrots", "4 potatoes", "1 onion" },
                new List<string> { "1. Brown beef", "2. Add vegetables", "3. Simmer for 2 hours" },
                "Main Dish",
                6,
                20,
                120,
                140,
                "Dad",
                "http://www.dad.com/recipes/beef-stew"
            ));
        }
    }
}

        }

        public Recipe()
        {
        }
        public static Recipe GetRandomRecipe()
        {
            if (AllRecipes.Count == 0)
            {
                InitializeRecipes();
            }

            Random random = new Random();
            int index = random.Next(AllRecipes.Count);
            return AllRecipes[index];
        }

        public static void InitializeRecipes()
        {
            AllRecipes.Clear();

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
                "Chicken Parmesan",
                new List<string> { "2 chicken breasts", "1 cup marinara sauce", "1 cup mozzarella cheese" },
                new List<string> { "1. Bread the chicken", "2. Fry chicken", "3. Top with sauce and cheese", "4. Bake until golden" },
                "Main Dish",
                2,
                15,
                25,
                40,
                "Grandma",
                "http://www.grandma.com/recipes/chicken-parmesan"
            ));

            AllRecipes.Add(new Recipe(
                "Beef Stew",
                new List<string> { "2 lbs. beef", "4 carrots", "4 potatoes", "1 onion" },
                new List<string> { "1. Brown beef", "2. Add vegetables", "3. Simmer for 2 hours" },
                "Main Dish",
                6,
                20,
                120,
                140,
                "Dad",
                "http://www.dad.com/recipes/beef-stew"
            ));
        }
    }
}
