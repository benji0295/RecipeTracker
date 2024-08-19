using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Dictionary<string, Recipe> Recipes { get; set; } 
        public List<GroceryItem> GroceryList { get; set; } 
        public List<GroceryItem> FridgeItems {  get; set; } 

        public Account(string username, string password, string firstName, string lastName, string email)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Recipes = new Dictionary<string, Recipe>();
            FridgeItems = new List<GroceryItem>();
            GroceryList = new List<GroceryItem>();
        }
    }
}
