using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker
{
    public class GroceryItem
    {
        public string Name { get; set; }
        public bool IsBought { get; set; }

        public GroceryItem(string name, bool isBought = false)
        {
            Name = name;
            IsBought = isBought;
        }
    }
}
