using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeTracker
{
    public partial class Form1 : Form
    {
        private Account loggedInAccount;
        private Recipe selectedRecipe;

        //
        // Main Form Code
        //
        #region Main Form
        public Form1(Account account)
        {
            InitializeComponent();
            loggedInAccount = account;
            userLabel.Text = loggedInAccount.FirstName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            RecipePanel.Visible = false;
            RecipeInfoPanel.Visible = false;
            GroceryPanel.Visible = false;
            FridgePanel.Visible = false;
            AccountPanel.Visible = false;
            AddToMealPlanPanel.Visible = false;
            MealPlanPanel.Visible = false;
            AddRecipePanel.Visible = false;
            AddGroceryItemPanel.Visible = false;
            AddFridgeItemPanel.Visible = false;

            try
            {
                Recipe recipeOfTheDay = Recipe.GetRandomRecipe(loggedInAccount);
                RecipeOfTheDayLabel.Text = recipeOfTheDay.Name;
                RecipeOfTheDayLabel.Tag = recipeOfTheDay;
                RecipeOfTheDayLabel.Click += RecipeOfTheDayLabel_Click;
            }
            catch (InvalidOperationException)
            {
                RecipeOfTheDayLabel.Text = "No recipes available.";
            }

            // Populate Recipes DataGridView
            dataGridViewRecipes.DataSource = null;
            dataGridViewRecipes.DataSource = loggedInAccount.Recipes.Values.ToList();  // Use the logged-in account's recipes
            dataGridViewRecipes.Columns["Name"].HeaderText = "Recipe Name";
            dataGridViewRecipes.Columns["Name"].ReadOnly = true;

            dataGridViewRecipes.CellMouseDoubleClick += dataGridViewRecipes_CellMouseDoubleClick;

            // Populate GroceryList DataGridView
            dataGridViewGrocery.DataSource = null;
            dataGridViewGrocery.DataSource = loggedInAccount.GroceryList;
            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;
            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";

            // Populate FridgeItems DataGridView
            dataGridViewFridge.DataSource = null;
            dataGridViewFridge.DataSource = loggedInAccount.FridgeItems;
            dataGridViewFridge.Columns["Name"].HeaderText = "Item";
            dataGridViewFridge.Columns["Name"].ReadOnly = true;
            dataGridViewFridge.Columns["IsBought"].HeaderText = "Used";
            dataGridViewFridge.Columns["IsBought"].ReadOnly = false;

        }

        private void RecipeOfTheDayLabel_Click(object sender, EventArgs e)
        {
            if (RecipeOfTheDayLabel.Tag != null)
            {
                Label recipeLabel = sender as Label;
                Recipe selectedRecipe = recipeLabel.Tag as Recipe;

                if (selectedRecipe != null)
                {
                    RecipeNameText.Text = selectedRecipe.Name;
                    PrepTimeTextBox.Text = $"{selectedRecipe.PrepTime.ToString()} minutes";
                    CookTimeTextBox.Text = $"{selectedRecipe.CookTime.ToString()} minutes";
                    TotalTimeTextBox.Text = $"{selectedRecipe.TotalTime.ToString()} minutes";
                    ServingSizeTextBox.Text = $"{selectedRecipe.Servings.ToString()} servings";
                    IngredientsTextBox.Text = string.Join("\r\n", selectedRecipe.Ingredients);
                    InstructionsTextBox.Text = string.Join("\r\n", selectedRecipe.Instructions);
                    SourceTextBox.Text = selectedRecipe.SourceURL;

                    RecipeInfoPanel.BringToFront();
                    RecipeInfoPanel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No recipe available.");
            }
        }
        #endregion

        //
        // Menu Panel Code
        //

        #region Menu Panel
        private void MainButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            MainPanel.BringToFront();
        }
        private void RecipeButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            RecipePanel.Visible = true;
            GroceryPanel.Visible = false;
            FridgePanel.Visible = false;
            AccountPanel.Visible = false;
            RecipeInfoPanel.Visible = false;
            AddToMealPlanPanel.Visible = false;
            MealPlanPanel.Visible = false;
            AddRecipePanel.Visible = false;
        }
        private void MealPlanButton_Click(object sender, EventArgs e)
        {
            MealPlanPanel.Visible = true;
            MealPlanPanel.BringToFront();
        }

        private void GroceryButton_Click(object sender, EventArgs e)
        {
            GroceryPanel.Visible = true;
            GroceryPanel.BringToFront();
        }

        private void FridgeButton_Click(object sender, EventArgs e)
        {
            FridgePanel.Visible = true;
            FridgePanel.BringToFront();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountPanel.Visible = true;
            AccountPanel.BringToFront();
        }
        #endregion

        //
        // My Recipes Code
        //

        #region Recipe Panel
        private void dataGridViewRecipes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Recipe selectedRecipe = dataGridViewRecipes.Rows[e.RowIndex].DataBoundItem as Recipe;

                if (selectedRecipe != null)
                {
                    RecipeNameText.Text = selectedRecipe.Name;
                    PrepTimeTextBox.Text = $"{selectedRecipe.PrepTime.ToString()} minutes";
                    CookTimeTextBox.Text = $"{selectedRecipe.CookTime.ToString()} minutes";
                    TotalTimeTextBox.Text = $"{selectedRecipe.TotalTime.ToString()} minutes";
                    ServingSizeTextBox.Text = $"{selectedRecipe.Servings.ToString()} servings";
                    IngredientsTextBox.Text = string.Join("\r\n", selectedRecipe.Ingredients);
                    InstructionsTextBox.Text = string.Join("\r\n", selectedRecipe.Instructions);
                    SourceTextBox.Text = selectedRecipe.SourceURL;

                    RecipeInfoPanel.BringToFront();
                    RecipeInfoPanel.Visible = true;
                }
            }
        }
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipePanel.Visible = true;
            AddRecipePanel.BringToFront();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecipes.SelectedRows.Count > 0)
            {
                Recipe selectedRecipe = dataGridViewRecipes.SelectedRows[0].DataBoundItem as Recipe;

                if (selectedRecipe != null)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete your {selectedRecipe.Name} recipe?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        loggedInAccount.Recipes.Remove(selectedRecipe.Name);

                        dataGridViewRecipes.DataSource = null;
                        dataGridViewRecipes.DataSource = loggedInAccount.Recipes.Values.ToList();

                        AccountManager.SaveAccounts();

                        RecipeInfoPanel.Visible = false;
                        RecipePanel.Visible = true;
                    }
                }
            }
        }
        #endregion

        //
        // Recipe Info Panel Code
        //

        #region Recipe Info Panel
        private void AddToMealPlanButton_Click(object sender, EventArgs e)
        {
            AddToMealPlanPanel.Visible = true;
            AddToMealPlanPanel.BringToFront();
        }
        private void BackToRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeInfoPanel.Visible = false;
            RecipePanel.Visible = true;
            RecipePanel.BringToFront();
        }

        private void AddIngredientsButton_Click(object sender, EventArgs e)
        {
            if (selectedRecipe != null)
            {
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    loggedInAccount.GroceryList.Add(new GroceryItem(ingredient));
                }

                dataGridViewGrocery.DataSource = null;
                dataGridViewGrocery.DataSource = loggedInAccount.GroceryList;

                MessageBox.Show("Ingredients added to your grocery list.");
            }
        }
        #endregion
        
        //
        // Meal Plan Panel
        //
        #region Meal Plan Panel
        private void AddAMealButton_Click(object sender, EventArgs e)
        {
            RecipePanel.Visible = true;
            RecipePanel.BringToFront();
            MealPlanPanel.Visible = false;
        }
        private void ClearMealPlanButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in MealPlanPanel.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }
        #endregion

        //
        // Fridge Panel Code
        //

        #region Fridge Panel
        private void AddToFridgeButton_Click(object sender, EventArgs e)
        {
            AddFridgeItemPanel.Visible = true;
            AddFridgeItemPanel.BringToFront();
        }
        private void SelectAllFridgeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewFridge.Rows)
            {
                row.Cells["IsBought"].Value = true;
            }
        }

        private void AddSelectedFridgeToGroceryButton_Click(object sender, EventArgs e)
        {
            List<GroceryItem> itemsToRemove = new List<GroceryItem>();

            foreach (DataGridViewRow row in dataGridViewFridge.Rows)
            {
                bool isBought = (bool)row.Cells["IsBought"].Value;

                if (isBought)
                {
                    GroceryItem fridgeItem = row.DataBoundItem as GroceryItem;

                    if (fridgeItem != null)
                    {
                        loggedInAccount.GroceryList.Add(new GroceryItem(fridgeItem.Name));
                        itemsToRemove.Add(fridgeItem);
                    }
                }
            }
            foreach (var item in itemsToRemove)
            {
                loggedInAccount.FridgeItems.Remove(item);
            }

            dataGridViewFridge.DataSource = null;
            dataGridViewFridge.DataSource = loggedInAccount.FridgeItems;

            dataGridViewFridge.Columns["Name"].HeaderText = "Item";
            dataGridViewFridge.Columns["Name"].ReadOnly = true;

            dataGridViewFridge.Columns["IsBought"].HeaderText = "Used";

            dataGridViewGrocery.DataSource = null;
            dataGridViewGrocery.DataSource = loggedInAccount.GroceryList;

            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;

            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";


            foreach (DataGridViewRow row in dataGridViewFridge.Rows)
            {
                row.Cells["IsBought"].Value = false;
            }
        }

        private void DeleteSelectedFridgeButton_Click(object sender, EventArgs e)
        {
            loggedInAccount.FridgeItems.RemoveAll(item => item.IsBought);

            dataGridViewFridge.DataSource = null;
            dataGridViewFridge.DataSource = loggedInAccount.FridgeItems;

            dataGridViewFridge.Columns["Name"].HeaderText = "Item";
            dataGridViewFridge.Columns["Name"].ReadOnly = true;

            dataGridViewFridge.Columns["IsBought"].HeaderText = "Used";
            dataGridViewFridge.Columns["IsBought"].ReadOnly = false;
        }

        private void DeleteFromFridgeButton_Click(object sender, EventArgs e)
        {
            // delete selected row from fridge
            if (dataGridViewFridge.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewFridge.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < loggedInAccount.FridgeItems.Count)
                {
                    loggedInAccount.FridgeItems.RemoveAt(selectedIndex);

                    dataGridViewFridge.DataSource = null;
                    dataGridViewFridge.DataSource = loggedInAccount.FridgeItems;

                    dataGridViewFridge.Columns["Name"].HeaderText = "Item";
                    dataGridViewFridge.Columns["Name"].ReadOnly = true;

                    dataGridViewFridge.Columns["IsBought"].HeaderText = "Used";
                    dataGridViewFridge.Columns["IsBought"].ReadOnly = false;
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
        #endregion

        //
        // Add Recipe To Meal Prep Panel
        //

        #region Add Recipe To Meal Plan Panel
        private void CancelAddRecipeButton_Click(object sender, EventArgs e)
        {
            AddToMealPlanPanel.Visible = false;
            ClearCheckBoxes();
        }

        private void RecipeAddToMealPlanButton_Click_1(object sender, EventArgs e)
        {
            string recipeName = RecipeNameText.Text;

            // Monday
            if (mondayBreakfastCheck.Checked)
            {
                mondayBreakfastText.Text = recipeName;
            }
            if (mondayLunchCheck.Checked)
            {
                mondayLunchText.Text = recipeName;
            }
            if (mondayDinnerCheck.Checked)
            {
                mondayDinnerText.Text = recipeName;
            }

            // Tuesday
            if (tuesdayBreakfastCheck.Checked)
            {
                tuesdayBreakfastText.Text = recipeName;
            }
            if (tuesdayLunchCheck.Checked)
            {
                tuesdayLunchText.Text = recipeName;
            }
            if (tuesdayDinnerCheck.Checked)
            {
                tuesdayDinnerText.Text = recipeName;
            }

            // Wednesday
            if (wednesdayBreakfastCheck.Checked)
            {
                wednesdayBreakfastText.Text = recipeName;
            }
            if (wednesdayLunchCheck.Checked)
            {
                wednesdayLunchText.Text = recipeName;
            }
            if (wednesdayDinnerCheck.Checked)
            {
                wednesdayDinnerText.Text = recipeName;
            }
            // Thursday
            if (thursdayBreakfastCheck.Checked)
            {
                thursdayBreakfastText.Text = recipeName;
            }
            if (thursdayLunchCheck.Checked)
            {
                thursdayLunchText.Text = recipeName;
            }
            if (thursdayDinnerCheck.Checked)
            {
                thursdayDinnerText.Text = recipeName;
            }

            // Friday
            if (fridayBreakfastCheck.Checked)
            {
                fridayBreakfastText.Text = recipeName;
            }
            if (fridayLunchCheck.Checked)
            {
                fridayLunchText.Text = recipeName;
            }
            if (fridayDinnerCheck.Checked)
            {
                fridayDinnerText.Text = recipeName;
            }

            // Saturday
            if (saturdayBreakfastCheck.Checked)
            {
                saturdayBreakfastText.Text = recipeName;
            }
            if (saturdayLunchCheck.Checked)
            {
                saturdayLunchText.Text = recipeName;
            }
            if (saturdayDinnerCheck.Checked)
            {
                saturdayDinnerText.Text = recipeName;
            }

            // Sunday
            if (sundayBreakfastCheck.Checked)
            {
                sundayBreakfastText.Text = recipeName;
            }
            if (sundayLunchCheck.Checked)
            {
                sundayLunchText.Text = recipeName;
            }
            if (sundayDinnerCheck.Checked)
            {
                sundayDinnerText.Text = recipeName;
            }

            // Clear checkboxes
            ClearCheckBoxes();
            AddToMealPlanPanel.Visible = false;
        }
        private void ClearCheckBoxes()
        {
            foreach (Control control in AddToMealPlanPanel.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
        #endregion

        //
        // Add New Recipe Panel
        //

        #region Add New Recipe Panel
        private void AddRecipePanelButton_Click(object sender, EventArgs e)
        {
            Recipe newRecipe = new Recipe();

            newRecipe.Name = NewRecipeNameTextBox.Text;
            newRecipe.Category = NewRecipeCategoryTextBox.Text;
            newRecipe.PrepTime = int.Parse(NewRecipePrepTextBox.Text);
            newRecipe.CookTime = int.Parse(NewRecipeCookTextBox.Text);
            newRecipe.TotalTime = (newRecipe.CookTime + newRecipe.PrepTime);
            newRecipe.Servings = int.Parse(NewRecipeSizeTextBox.Text);
            newRecipe.Source = NewRecipeSourceTextBox.Text;
            newRecipe.SourceURL = NewRecipeSourceURLTextBox.Text;
            newRecipe.Ingredients = NewRecipeIngredientsTextBox.Text.Split('\n').ToList();
            newRecipe.Instructions = NewRecipeInstructionsTextBox.Text.Split('\n').ToList();

            if (!loggedInAccount.Recipes.ContainsKey(newRecipe.Name))
            {
                loggedInAccount.Recipes.Add(newRecipe.Name, newRecipe);
            }
            else
            {
                MessageBox.Show("A recipe with this name already exists");
                return;
            }

            dataGridViewRecipes.DataSource = null;
            dataGridViewRecipes.DataSource = loggedInAccount.Recipes.Values.ToList();

            AddRecipePanel.Visible = false;

            AccountManager.SaveAccounts();
        }
        private void CancelAddRecipePanelButton_Click(object sender, EventArgs e)
        {
            AddRecipePanel.Visible = false;
        }
        #endregion

        //
        // Account Panel
        //
        #region Account Panel
        private void ConfirmNewPasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmNewEmailButton_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        #endregion

        //
        // Grocery List Panel
        //
        #region Grocery List Panel
        private void AddGroceryButton_Click(object sender, EventArgs e)
        {
            AddGroceryItemPanel.Visible = true;
            AddGroceryItemPanel.BringToFront();
        }
        private void AddGroceriesToFridgeButton_Click(object sender, EventArgs e)
        {
            List<GroceryItem> itemsToMove = new List<GroceryItem>();

            foreach (DataGridViewRow row in dataGridViewGrocery.Rows)
            {
                bool isBought = (bool)row.Cells["IsBought"].Value;

                if (isBought)
                {
                    GroceryItem groceryItem = row.DataBoundItem as GroceryItem;

                    if (groceryItem != null)
                    {
                        var newFridgeItem = new GroceryItem(groceryItem.Name);

                        loggedInAccount.FridgeItems.Add(newFridgeItem);
                        itemsToMove.Add(groceryItem);
                    }
                }
            }
            foreach (var item in itemsToMove)
            {
                loggedInAccount.GroceryList.Remove(item);
            }

            var groceryBindingSource = new BindingSource();
            groceryBindingSource.DataSource = loggedInAccount.GroceryList;
            dataGridViewGrocery.DataSource = groceryBindingSource;

            var fridgeBindingSource = new BindingSource();
            fridgeBindingSource.DataSource = loggedInAccount.FridgeItems;
            dataGridViewFridge.DataSource = fridgeBindingSource;

            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;
            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";

            dataGridViewFridge.Columns["Name"].HeaderText = "Item";
            dataGridViewFridge.Columns["Name"].ReadOnly = true;
            dataGridViewFridge.Columns["IsBought"].HeaderText = "Used";
            dataGridViewFridge.Columns["IsBought"].ReadOnly = false;
        }
        private void SelectAllGroceryItemsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewGrocery.Rows)
            {
                row.Cells["IsBought"].Value = true;
            }
        }

        private void DeleteGroceryButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrocery.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewGrocery.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < loggedInAccount.GroceryList.Count)
                {
                    loggedInAccount.GroceryList.RemoveAt(selectedIndex);

                    dataGridViewGrocery.DataSource = null;
                    dataGridViewGrocery.DataSource = loggedInAccount.GroceryList;

                    dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
                    dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void ClearSelectedGroceryButton_Click(object sender, EventArgs e)
        {
            loggedInAccount.GroceryList.RemoveAll(item => item.IsBought);

            dataGridViewGrocery.DataSource = null;
            dataGridViewGrocery.DataSource = loggedInAccount.GroceryList;

            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;

            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";
        }

        private void ClearGroceryListButton_Click(object sender, EventArgs e)
        {
            loggedInAccount.GroceryList.Clear();

            dataGridViewGrocery.DataSource = null;
            dataGridViewGrocery.DataSource = loggedInAccount.GroceryList    ;

            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;

            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";
        }
        #endregion

        //
        // Add Grocery Item Panel
        //
        #region Add Grocery Item Panel
        private void AddGroceryItemButton_Click(object sender, EventArgs e)
        {
            string newItemName = NewGroceryItemText.Text;

            if (!string.IsNullOrEmpty(newItemName))
            {
                newItemName = char.ToUpper(newItemName[0]) + newItemName.Substring(1).ToLower();

                loggedInAccount.GroceryList.Add(new GroceryItem(newItemName));

                NewGroceryItemText.Clear();

                AddGroceryItemPanel.Visible = false;

                dataGridViewGrocery.DataSource = null;
                dataGridViewGrocery.DataSource = loggedInAccount.GroceryList;

                dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
                dataGridViewGrocery.Columns["Name"].ReadOnly = true;

                dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";
            }
            else
            {
                MessageBox.Show("Please enter a grocery item to add.");
            }
        }

        private void CancelAddGroceryItemButton_Click(object sender, EventArgs e)
        {
            AddGroceryItemPanel.Visible = false;
        }
        #endregion

        //
        // Add New Fridge Item
        //
        #region Add New Fridge Item
        private void AddNewFridgeItemButton_Click(object sender, EventArgs e)
        {
            string newItemName = AddFridgeItemText.Text;

            if (!string.IsNullOrEmpty(newItemName))
            {
                newItemName = char.ToUpper(newItemName[0]) + newItemName.Substring(1).ToLower();

                if (!loggedInAccount.FridgeItems.Any(item => item.Name == newItemName))
                {
                    var newFridgeItem = new GroceryItem(newItemName);
                    loggedInAccount.FridgeItems.Add(newFridgeItem);

                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = loggedInAccount.FridgeItems;
                    dataGridViewFridge.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("Item already exists in fridge.");
                }

                AddFridgeItemText.Clear();
                AddFridgeItemPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter a grocery item to add.");
            }
        }

        private void CancelAddFridgeItem_Click(object sender, EventArgs e)
        {
            AddFridgeItemPanel.Visible = false;
        }
        #endregion
    }
}
