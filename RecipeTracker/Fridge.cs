using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker
{
    internal class Fridge
    {
        public List<GroceryItem> Items { get; set; }

        public Fridge()
        {
            Items = new List<GroceryItem>();
        }
        public void AddItem(GroceryItem item)
        {
            Items.Add(item);
        }
        public void ClearFridge()
        {
            Items.Clear();
        }
    }
}
