using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeTracker
{
    public class GroceryList
    {
        public List<GroceryItem> Items { get; set; }

        public GroceryList()
        {
            Items = new List<GroceryItem>();
        }
        public void InitializeGroceryList()
        {
            Items.Add(new GroceryItem("Milk"));
            Items.Add(new GroceryItem("Eggs"));
            Items.Add(new GroceryItem("Bread"));
        }

        public void AddItem(string name)
        {
            Items.Add(new GroceryItem(name));
        }

        public void RemoveItem(GroceryItem item)
        {
            Items.Remove(item);
        }

        public void MarkAsBought(GroceryItem item)
        {
            var foundItem = Items.FirstOrDefault(i => i == item);
            if (foundItem != null)
            {
                foundItem.IsBought = true;
            }
        }

        public void MarkAsNotBought(string name)
        {
            var item = Items.Find(i => i.Name == name);
            if (item != null)
            {
                item.IsBought = false;
            }
        }

        public void ClearList()
        {
            Items.Clear();
        }
    }
}
