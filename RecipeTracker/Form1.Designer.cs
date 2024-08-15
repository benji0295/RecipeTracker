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
            this.GroceryButton = new System.Windows.Forms.Button();
            this.FridgeButton = new System.Windows.Forms.Button();
            this.RecipeButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GroceryPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FridgePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RecipeInfoPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.GroceryPanel.SuspendLayout();
            this.FridgePanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RecipeInfoPanel.SuspendLayout();
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
            this.RecipePanel.Controls.Add(this.dataGridView1);
            this.RecipePanel.Controls.Add(this.label2);
            this.RecipePanel.Location = new System.Drawing.Point(321, 0);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(1551, 1323);
            this.RecipePanel.TabIndex = 3;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 1249);
            this.dataGridView1.TabIndex = 1;
            // 
            // RecipeInfoPanel
            // 
            this.RecipeInfoPanel.Controls.Add(this.label6);
            this.RecipeInfoPanel.Location = new System.Drawing.Point(1030, 72);
            this.RecipeInfoPanel.Name = "RecipeInfoPanel";
            this.RecipeInfoPanel.Size = new System.Drawing.Size(520, 1245);
            this.RecipeInfoPanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Recipe Info";
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
            this.GroceryPanel.ResumeLayout(false);
            this.GroceryPanel.PerformLayout();
            this.FridgePanel.ResumeLayout(false);
            this.FridgePanel.PerformLayout();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RecipeInfoPanel.ResumeLayout(false);
            this.RecipeInfoPanel.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MainButton;
    }
}

