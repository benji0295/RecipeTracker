namespace RecipeTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.MainButton = new System.Windows.Forms.Button();
            this.GroceryButton = new System.Windows.Forms.Button();
            this.FridgeButton = new System.Windows.Forms.Button();
            this.RecipeButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.RecipeInfoPanel = new System.Windows.Forms.Panel();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.TotalTimeTextBox = new System.Windows.Forms.TextBox();
            this.CookTimeTextBox = new System.Windows.Forms.TextBox();
            this.PrepTimeTextBox = new System.Windows.Forms.TextBox();
            this.ServingSizeTextBox = new System.Windows.Forms.TextBox();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.IngredientsTextBox = new System.Windows.Forms.TextBox();
            this.RecipeNameText = new System.Windows.Forms.TextBox();
            this.BackToRecipeButton = new System.Windows.Forms.Button();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.ServingSizeLabel = new System.Windows.Forms.Label();
            this.CookTimeLabel = new System.Windows.Forms.Label();
            this.PrepTimeLabel = new System.Windows.Forms.Label();
            this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GroceryPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FridgePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.RecipeInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
            this.GroceryPanel.SuspendLayout();
            this.FridgePanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.MainButton);
            this.menuPanel.Controls.Add(this.GroceryButton);
            this.menuPanel.Controls.Add(this.FridgeButton);
            this.menuPanel.Controls.Add(this.RecipeButton);
            this.menuPanel.Controls.Add(this.AccountButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(319, 1323);
            this.menuPanel.TabIndex = 0;
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(3, 511);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(312, 157);
            this.MainButton.TabIndex = 4;
            this.MainButton.Text = "Main Menu";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // GroceryButton
            // 
            this.GroceryButton.Location = new System.Drawing.Point(3, 837);
            this.GroceryButton.Name = "GroceryButton";
            this.GroceryButton.Size = new System.Drawing.Size(312, 157);
            this.GroceryButton.TabIndex = 2;
            this.GroceryButton.Text = "My Grocery List";
            this.GroceryButton.UseVisualStyleBackColor = true;
            this.GroceryButton.Click += new System.EventHandler(this.GroceryButton_Click);
            // 
            // FridgeButton
            // 
            this.FridgeButton.Location = new System.Drawing.Point(3, 1000);
            this.FridgeButton.Name = "FridgeButton";
            this.FridgeButton.Size = new System.Drawing.Size(312, 157);
            this.FridgeButton.TabIndex = 1;
            this.FridgeButton.Text = "My Fridge";
            this.FridgeButton.UseVisualStyleBackColor = true;
            this.FridgeButton.Click += new System.EventHandler(this.FridgeButton_Click);
            // 
            // RecipeButton
            // 
            this.RecipeButton.Location = new System.Drawing.Point(3, 674);
            this.RecipeButton.Name = "RecipeButton";
            this.RecipeButton.Size = new System.Drawing.Size(312, 157);
            this.RecipeButton.TabIndex = 0;
            this.RecipeButton.Text = "My Recipes";
            this.RecipeButton.UseVisualStyleBackColor = true;
            this.RecipeButton.Click += new System.EventHandler(this.RecipeButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(3, 1163);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(312, 157);
            this.AccountButton.TabIndex = 3;
            this.AccountButton.Text = "My Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(321, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1554, 1323);
            this.MainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main";
            // 
            // RecipePanel
            // 
            this.RecipePanel.Controls.Add(this.RecipeInfoPanel);
            this.RecipePanel.Controls.Add(this.dataGridViewRecipes);
            this.RecipePanel.Controls.Add(this.label2);
            this.RecipePanel.Location = new System.Drawing.Point(321, 0);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(1551, 1323);
            this.RecipePanel.TabIndex = 3;
            // 
            // RecipeInfoPanel
            // 
            this.RecipeInfoPanel.Controls.Add(this.SourceTextBox);
            this.RecipeInfoPanel.Controls.Add(this.TotalTimeTextBox);
            this.RecipeInfoPanel.Controls.Add(this.CookTimeTextBox);
            this.RecipeInfoPanel.Controls.Add(this.PrepTimeTextBox);
            this.RecipeInfoPanel.Controls.Add(this.ServingSizeTextBox);
            this.RecipeInfoPanel.Controls.Add(this.StepsTextBox);
            this.RecipeInfoPanel.Controls.Add(this.IngredientsTextBox);
            this.RecipeInfoPanel.Controls.Add(this.RecipeNameText);
            this.RecipeInfoPanel.Controls.Add(this.BackToRecipeButton);
            this.RecipeInfoPanel.Controls.Add(this.SourceLabel);
            this.RecipeInfoPanel.Controls.Add(this.StepsLabel);
            this.RecipeInfoPanel.Controls.Add(this.IngredientsLabel);
            this.RecipeInfoPanel.Controls.Add(this.TotalTimeLabel);
            this.RecipeInfoPanel.Controls.Add(this.ServingSizeLabel);
            this.RecipeInfoPanel.Controls.Add(this.CookTimeLabel);
            this.RecipeInfoPanel.Controls.Add(this.PrepTimeLabel);
            this.RecipeInfoPanel.Location = new System.Drawing.Point(4, 3);
            this.RecipeInfoPanel.Name = "RecipeInfoPanel";
            this.RecipeInfoPanel.Size = new System.Drawing.Size(1546, 1314);
            this.RecipeInfoPanel.TabIndex = 2;
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceTextBox.Location = new System.Drawing.Point(1182, 48);
            this.SourceTextBox.Multiline = true;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(342, 80);
            this.SourceTextBox.TabIndex = 16;
            // 
            // TotalTimeTextBox
            // 
            this.TotalTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TotalTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalTimeTextBox.Location = new System.Drawing.Point(120, 214);
            this.TotalTimeTextBox.Name = "TotalTimeTextBox";
            this.TotalTimeTextBox.Size = new System.Drawing.Size(100, 24);
            this.TotalTimeTextBox.TabIndex = 15;
            // 
            // CookTimeTextBox
            // 
            this.CookTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CookTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CookTimeTextBox.Location = new System.Drawing.Point(120, 168);
            this.CookTimeTextBox.Name = "CookTimeTextBox";
            this.CookTimeTextBox.Size = new System.Drawing.Size(100, 24);
            this.CookTimeTextBox.TabIndex = 14;
            // 
            // PrepTimeTextBox
            // 
            this.PrepTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PrepTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrepTimeTextBox.Location = new System.Drawing.Point(120, 122);
            this.PrepTimeTextBox.Name = "PrepTimeTextBox";
            this.PrepTimeTextBox.Size = new System.Drawing.Size(100, 24);
            this.PrepTimeTextBox.TabIndex = 13;
            // 
            // ServingSizeTextBox
            // 
            this.ServingSizeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ServingSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServingSizeTextBox.Location = new System.Drawing.Point(138, 77);
            this.ServingSizeTextBox.Name = "ServingSizeTextBox";
            this.ServingSizeTextBox.Size = new System.Drawing.Size(129, 24);
            this.ServingSizeTextBox.TabIndex = 12;
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StepsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StepsTextBox.Location = new System.Drawing.Point(25, 693);
            this.StepsTextBox.Multiline = true;
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(1493, 542);
            this.StepsTextBox.TabIndex = 11;
            // 
            // IngredientsTextBox
            // 
            this.IngredientsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IngredientsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IngredientsTextBox.Location = new System.Drawing.Point(25, 284);
            this.IngredientsTextBox.Multiline = true;
            this.IngredientsTextBox.Name = "IngredientsTextBox";
            this.IngredientsTextBox.Size = new System.Drawing.Size(1493, 358);
            this.IngredientsTextBox.TabIndex = 10;
            // 
            // RecipeNameText
            // 
            this.RecipeNameText.BackColor = System.Drawing.SystemColors.Control;
            this.RecipeNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecipeNameText.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeNameText.Location = new System.Drawing.Point(595, 15);
            this.RecipeNameText.Multiline = true;
            this.RecipeNameText.Name = "RecipeNameText";
            this.RecipeNameText.ReadOnly = true;
            this.RecipeNameText.Size = new System.Drawing.Size(349, 51);
            this.RecipeNameText.TabIndex = 9;
            this.RecipeNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackToRecipeButton
            // 
            this.BackToRecipeButton.Location = new System.Drawing.Point(1360, 1241);
            this.BackToRecipeButton.Name = "BackToRecipeButton";
            this.BackToRecipeButton.Size = new System.Drawing.Size(176, 67);
            this.BackToRecipeButton.TabIndex = 8;
            this.BackToRecipeButton.Text = "Back To Recipes";
            this.BackToRecipeButton.UseVisualStyleBackColor = true;
            this.BackToRecipeButton.Click += new System.EventHandler(this.BackToRecipeButton_Click);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(1316, 20);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(80, 25);
            this.SourceLabel.TabIndex = 7;
            this.SourceLabel.Text = "Source";
            // 
            // StepsLabel
            // 
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Font = new System.Drawing.Font("Arial Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsLabel.Location = new System.Drawing.Point(705, 652);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(102, 38);
            this.StepsLabel.TabIndex = 6;
            this.StepsLabel.Text = "Steps";
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsLabel.Location = new System.Drawing.Point(676, 248);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(165, 33);
            this.IngredientsLabel.TabIndex = 5;
            this.IngredientsLabel.Text = "Ingredients";
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Location = new System.Drawing.Point(5, 214);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(119, 25);
            this.TotalTimeLabel.TabIndex = 4;
            this.TotalTimeLabel.Text = "Total Time:";
            // 
            // ServingSizeLabel
            // 
            this.ServingSizeLabel.AutoSize = true;
            this.ServingSizeLabel.Location = new System.Drawing.Point(3, 77);
            this.ServingSizeLabel.Name = "ServingSizeLabel";
            this.ServingSizeLabel.Size = new System.Drawing.Size(139, 25);
            this.ServingSizeLabel.TabIndex = 3;
            this.ServingSizeLabel.Text = "Serving Size:";
            // 
            // CookTimeLabel
            // 
            this.CookTimeLabel.AutoSize = true;
            this.CookTimeLabel.Location = new System.Drawing.Point(3, 168);
            this.CookTimeLabel.Name = "CookTimeLabel";
            this.CookTimeLabel.Size = new System.Drawing.Size(121, 25);
            this.CookTimeLabel.TabIndex = 2;
            this.CookTimeLabel.Text = "Cook Time:";
            // 
            // PrepTimeLabel
            // 
            this.PrepTimeLabel.AutoSize = true;
            this.PrepTimeLabel.Location = new System.Drawing.Point(3, 122);
            this.PrepTimeLabel.Name = "PrepTimeLabel";
            this.PrepTimeLabel.Size = new System.Drawing.Size(116, 25);
            this.PrepTimeLabel.TabIndex = 1;
            this.PrepTimeLabel.Text = "Prep Time:";
            // 
            // dataGridViewRecipes
            // 
            this.dataGridViewRecipes.AllowUserToAddRows = false;
            this.dataGridViewRecipes.AllowUserToDeleteRows = false;
            this.dataGridViewRecipes.AllowUserToResizeColumns = false;
            this.dataGridViewRecipes.AllowUserToResizeRows = false;
            this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipes.Location = new System.Drawing.Point(4, 71);
            this.dataGridViewRecipes.Name = "dataGridViewRecipes";
            this.dataGridViewRecipes.ReadOnly = true;
            this.dataGridViewRecipes.RowHeadersVisible = false;
            this.dataGridViewRecipes.RowHeadersWidth = 82;
            this.dataGridViewRecipes.RowTemplate.Height = 33;
            this.dataGridViewRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecipes.Size = new System.Drawing.Size(1547, 1249);
            this.dataGridViewRecipes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "My Recipes";
            // 
            // GroceryPanel
            // 
            this.GroceryPanel.Controls.Add(this.label3);
            this.GroceryPanel.Location = new System.Drawing.Point(321, 0);
            this.GroceryPanel.Name = "GroceryPanel";
            this.GroceryPanel.Size = new System.Drawing.Size(1551, 1320);
            this.GroceryPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "My Grocery List";
            // 
            // FridgePanel
            // 
            this.FridgePanel.Controls.Add(this.label4);
            this.FridgePanel.Location = new System.Drawing.Point(321, 0);
            this.FridgePanel.Name = "FridgePanel";
            this.FridgePanel.Size = new System.Drawing.Size(1554, 1323);
            this.FridgePanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "My Fridge";
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.label5);
            this.AccountPanel.Location = new System.Drawing.Point(321, 0);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(1554, 1323);
            this.AccountPanel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "My Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1873, 1323);
            this.Controls.Add(this.RecipePanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.AccountPanel);
            this.Controls.Add(this.FridgePanel);
            this.Controls.Add(this.GroceryPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.RecipePanel.ResumeLayout(false);
            this.RecipePanel.PerformLayout();
            this.RecipeInfoPanel.ResumeLayout(false);
            this.RecipeInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
            this.GroceryPanel.ResumeLayout(false);
            this.GroceryPanel.PerformLayout();
            this.FridgePanel.ResumeLayout(false);
            this.FridgePanel.PerformLayout();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button GroceryButton;
        private System.Windows.Forms.Button FridgeButton;
        private System.Windows.Forms.Button RecipeButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RecipePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GroceryPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel FridgePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel RecipeInfoPanel;
        private System.Windows.Forms.DataGridView dataGridViewRecipes;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label CookTimeLabel;
        private System.Windows.Forms.Label PrepTimeLabel;
        private System.Windows.Forms.Label ServingSizeLabel;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.Button BackToRecipeButton;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label StepsLabel;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.TextBox RecipeNameText;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox TotalTimeTextBox;
        private System.Windows.Forms.TextBox CookTimeTextBox;
        private System.Windows.Forms.TextBox PrepTimeTextBox;
        private System.Windows.Forms.TextBox ServingSizeTextBox;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.TextBox IngredientsTextBox;
    }
}

