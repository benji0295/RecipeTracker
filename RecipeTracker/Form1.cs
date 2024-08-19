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
        private Fridge fridge;
        private Recipe selectedRecipe;
        private GroceryList groceryList;
        //
        // Main Form Code
        //
        public Form1()
        {
            InitializeComponent();
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

            Recipe recipeOfTheDay = Recipe.GetRandomRecipe();

            RecipeOfTheDayLabel.Text = recipeOfTheDay.Name;

            RecipeOfTheDayLabel.Tag = recipeOfTheDay;

            RecipeOfTheDayLabel.Click += RecipeOfTheDayLabel_Click;

            dataGridViewRecipes.DataSource = null;

            dataGridViewRecipes.DataSource = Recipe.AllRecipes;

            dataGridViewRecipes.CellMouseDoubleClick += dataGridViewRecipes_CellMouseDoubleClick;

            // Grocery List Grid View
            groceryList = new GroceryList();
            groceryList.InitializeGroceryList();

            dataGridViewGrocery.AutoGenerateColumns = true;
            dataGridViewGrocery.DataSource = groceryList.Items;

            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;

            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";

            // Fridge
            fridge = new Fridge();
        }

        private void RecipeOfTheDayLabel_Click(object sender, EventArgs e)
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

        //
        // Menu Panel Code
        //
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

        //
        // My Recipes Code
        //

        private void dataGridViewRecipes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRecipe = dataGridViewRecipes.Rows[e.RowIndex].DataBoundItem as Recipe;

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

        private void BackToRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeInfoPanel.Visible = false;
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
                        Recipe.AllRecipes.Remove(selectedRecipe);
                        dataGridViewRecipes.DataSource = null;
                        dataGridViewRecipes.DataSource = Recipe.AllRecipes;

                        RecipeInfoPanel.Visible = false;
                        RecipePanel.Visible = true;
                    }
                }
            }
        }

        //
        // Recipe Info Panel Code
        //
        private void AddToMealPlanButton_Click(object sender, EventArgs e)
        {
            AddToMealPlanPanel.Visible = true;
            AddToMealPlanPanel.BringToFront();
        }

        private void AddIngredientsButton_Click(object sender, EventArgs e)
        {
            if (selectedRecipe != null)
            {
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    groceryList.AddItem(ingredient);
                }

                dataGridViewGrocery.DataSource = null;
                dataGridViewGrocery.DataSource = groceryList.Items;

                MessageBox.Show("Ingredients added to your grocery list.");
            }
        }
        //
        // Meal Plan Panel
        //
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

        //
        // Fridge Panel Code
        //

        private void AddToFridgeButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFromFridgeButton_Click(object sender, EventArgs e)
        {

        }
        //
        // Add Recipe To Meal Prep Panel
        //

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

        //
        // Add New Recipe Panel
        //
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
            Recipe.AllRecipes.Add(newRecipe);
            dataGridViewRecipes.DataSource = null;
            dataGridViewRecipes.DataSource = Recipe.AllRecipes;
            AddRecipePanel.Visible = false;

            
        }
        private void CancelAddRecipePanelButton_Click(object sender, EventArgs e)
        {
            AddRecipePanel.Visible = false;
        }

        //
        // Account Panel
        //
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

        //
        // Grocery List Panel
        //
        private void AddGroceryButton_Click(object sender, EventArgs e)
        {
            AddGroceryItemPanel.Visible = true;
            AddGroceryItemPanel.BringToFront();
        }
        private void AddGroceriesToFridgeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewGrocery.Rows)
            {
                bool isBought = (bool)row.Cells["IsBought"].Value;

                if (isBought)
                {
                    GroceryItem groceryItem = row.DataBoundItem as GroceryItem;

                    if (groceryItem != null)
                    {
                        fridge.AddItem(groceryItem);
                    }
                }
            }

            dataGridViewFridge.DataSource = null;
            dataGridViewFridge.DataSource = fridge.Items;

            groceryList.Items.RemoveAll(item => item.IsBought);

            dataGridViewGrocery.DataSource = null;
            dataGridViewGrocery.DataSource = groceryList.Items;
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

                if (selectedIndex >= 0 && selectedIndex < groceryList.Items.Count)
                {
                    groceryList.Items.RemoveAt(selectedIndex);

                    dataGridViewGrocery.DataSource = null;
                    dataGridViewGrocery.DataSource = groceryList.Items;

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
            groceryList.Items.RemoveAll(item => item.IsBought);

            dataGridViewGrocery.DataSource = null;
            dataGridViewGrocery.DataSource = groceryList.Items;

            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;

            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";
        }

        private void ClearGroceryListButton_Click(object sender, EventArgs e)
        {
            groceryList.ClearList();

            dataGridViewGrocery.DataSource = null;
            dataGridViewGrocery.DataSource = groceryList.Items;

            dataGridViewGrocery.Columns["Name"].HeaderText = "Item";
            dataGridViewGrocery.Columns["Name"].ReadOnly = true;

            dataGridViewGrocery.Columns["IsBought"].HeaderText = "Bought";
        }

        //
        // Add Grocery Item Panel
        //
        private void AddGroceryItemButton_Click(object sender, EventArgs e)
        {
            string newItemName = NewGroceryItemText.Text;

            if (!string.IsNullOrEmpty(newItemName))
            {
                newItemName = char.ToUpper(newItemName[0]) + newItemName.Substring(1).ToLower();

                groceryList.AddItem(newItemName);

                NewGroceryItemText.Clear();

                AddGroceryItemPanel.Visible = false;

                dataGridViewGrocery.DataSource = null;
                dataGridViewGrocery.DataSource = groceryList.Items;

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
    }
}
