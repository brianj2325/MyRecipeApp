namespace MyRecipesApp
{
    partial class Form3
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
            this.btn_AddRecipe = new System.Windows.Forms.Button();
            this.btn_BrowseRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // btn_AddRecipe
            // 
            this.btn_AddRecipe.Location = new System.Drawing.Point(95, 206);
            this.btn_AddRecipe.Name = "btn_AddRecipe";
            this.btn_AddRecipe.Size = new System.Drawing.Size(156, 141);
            this.btn_AddRecipe.TabIndex = 1;
            this.btn_AddRecipe.Text = "ADD RECIPE";
            this.btn_AddRecipe.UseVisualStyleBackColor = true;
            this.btn_AddRecipe.Click += new System.EventHandler(this.btn_AddRecipe_Click);
            // 
            // btn_BrowseRecipe
            // 
            this.btn_BrowseRecipe.Location = new System.Drawing.Point(459, 215);
            this.btn_BrowseRecipe.Name = "btn_BrowseRecipe";
            this.btn_BrowseRecipe.Size = new System.Drawing.Size(156, 142);
            this.btn_BrowseRecipe.TabIndex = 2;
            this.btn_BrowseRecipe.Text = "BROWSE RECIPES";
            this.btn_BrowseRecipe.UseVisualStyleBackColor = true;
            this.btn_BrowseRecipe.Click += new System.EventHandler(this.btn_BrowseRecipe_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_BrowseRecipe);
            this.Controls.Add(this.btn_AddRecipe);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Welcome to MyRecipes! ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddRecipe;
        private System.Windows.Forms.Button btn_BrowseRecipe;
    }
}