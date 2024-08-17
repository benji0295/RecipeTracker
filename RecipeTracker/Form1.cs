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

        /// <summary>
        /// Main Form Code
        /// </summary>
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
            Recipe.InitializeRecipes();
            dataGridViewRecipes.DataSource = Recipe.AllRecipes;

            dataGridViewRecipes.CellMouseDoubleClick += dataGridViewRecipes_CellMouseDoubleClick;

        }
        /// <summary>
        /// Menu Panel Code
        /// </summary>
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

        /// <summary>
        /// My Recipes Code
        /// </summary>

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

        private void AddToMealPlanButton_Click(object sender, EventArgs e)
        {
            AddToMealPlanPanel.Visible = true;
            AddToMealPlanPanel.BringToFront();
        }

        /// <summary>
        /// Ingredients Panel Code
        /// </summary>

        private void AddIngredientsButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Meal Plan Panel
        /// </summary>
        private void AddAMealButton_Click(object sender, EventArgs e)
        {
            RecipePanel.Visible = true;
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

        /// <summary>
        /// Fridge Panel Code
        /// </summary>

        private void AddToFridgeButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFromFridgeButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Add Recipe To Meal Prep Panel
        /// </summary>

        private void CancelAddRecipeButton_Click(object sender, EventArgs e)
        {
            AddToMealPlanPanel.Visible = false;
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

        /// <summary>
        /// Add New Recipe Panel
        /// </summary>
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
    }
}
