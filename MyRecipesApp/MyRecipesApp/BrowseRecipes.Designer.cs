namespace MyRecipesApp
{
    partial class BrowseRecipes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_BrowseRecipes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_BrowseCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrowseRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse Recipes";
            // 
            // dgv_BrowseRecipes
            // 
            this.dgv_BrowseRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BrowseRecipes.Location = new System.Drawing.Point(51, 132);
            this.dgv_BrowseRecipes.Name = "dgv_BrowseRecipes";
            this.dgv_BrowseRecipes.Size = new System.Drawing.Size(671, 449);
            this.dgv_BrowseRecipes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Browse by category: ";
            // 
            // cmb_BrowseCategory
            // 
            this.cmb_BrowseCategory.FormattingEnabled = true;
            this.cmb_BrowseCategory.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Desserts",
            "Appetizer",
            "Drink",
            "Show All"});
            this.cmb_BrowseCategory.Location = new System.Drawing.Point(199, 83);
            this.cmb_BrowseCategory.Name = "cmb_BrowseCategory";
            this.cmb_BrowseCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_BrowseCategory.TabIndex = 3;
            this.cmb_BrowseCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_BrowseCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search by Recipe Name:";
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.Location = new System.Drawing.Point(532, 83);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.Size = new System.Drawing.Size(185, 20);
            this.txt_SearchBox.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(571, 106);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 20);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_AddRecipe
            // 
            this.btn_AddRecipe.Location = new System.Drawing.Point(217, 602);
            this.btn_AddRecipe.Name = "btn_AddRecipe";
            this.btn_AddRecipe.Size = new System.Drawing.Size(123, 26);
            this.btn_AddRecipe.TabIndex = 7;
            this.btn_AddRecipe.Text = "Add Recipe";
            this.btn_AddRecipe.UseVisualStyleBackColor = true;
            this.btn_AddRecipe.Click += new System.EventHandler(this.btn_AddRecipe_Click);
            // 
            // BrowseRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.btn_AddRecipe);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_BrowseCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_BrowseRecipes);
            this.Controls.Add(this.label1);
            this.Name = "BrowseRecipes";
            this.Text = "BrowseRecipes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrowseRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_BrowseRecipes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_BrowseCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SearchBox;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_AddRecipe;
    }
}