namespace MyRecipesApp
{
    partial class AddIngredientsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_RecipeName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_RecipeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Ingredients = new System.Windows.Forms.DataGridView();
            this.myRecipeAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_AddDirections = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Amount1 = new System.Windows.Forms.ComboBox();
            this.cmb_Amount2 = new System.Windows.Forms.ComboBox();
            this.cmb_Units = new System.Windows.Forms.ComboBox();
            this.btn_AddIngredient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_IngredientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ingredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRecipeAppDBDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipe Name:";
            // 
            // lbl_RecipeName
            // 
            this.lbl_RecipeName.AutoSize = true;
            this.lbl_RecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecipeName.Location = new System.Drawing.Point(563, 94);
            this.lbl_RecipeName.Name = "lbl_RecipeName";
            this.lbl_RecipeName.Size = new System.Drawing.Size(198, 24);
            this.lbl_RecipeName.TabIndex = 2;
            this.lbl_RecipeName.Text = "this is the recipe name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recipe ID:";
            // 
            // lbl_RecipeID
            // 
            this.lbl_RecipeID.AutoSize = true;
            this.lbl_RecipeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecipeID.Location = new System.Drawing.Point(661, 118);
            this.lbl_RecipeID.Name = "lbl_RecipeID";
            this.lbl_RecipeID.Size = new System.Drawing.Size(100, 24);
            this.lbl_RecipeID.TabIndex = 4;
            this.lbl_RecipeID.Text = "123456789";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingredient Name";
            // 
            // dgv_Ingredients
            // 
            this.dgv_Ingredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ingredients.Location = new System.Drawing.Point(422, 141);
            this.dgv_Ingredients.Name = "dgv_Ingredients";
            this.dgv_Ingredients.Size = new System.Drawing.Size(339, 215);
            this.dgv_Ingredients.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "List of Ingredients for:";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(240, 398);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(92, 33);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(338, 398);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(92, 33);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_AddDirections
            // 
            this.btn_AddDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDirections.Location = new System.Drawing.Point(436, 398);
            this.btn_AddDirections.Name = "btn_AddDirections";
            this.btn_AddDirections.Size = new System.Drawing.Size(150, 33);
            this.btn_AddDirections.TabIndex = 17;
            this.btn_AddDirections.Text = "Add Directions";
            this.btn_AddDirections.UseVisualStyleBackColor = true;
            this.btn_AddDirections.Click += new System.EventHandler(this.btn_AddDirections_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Units";
            // 
            // cmb_Amount1
            // 
            this.cmb_Amount1.FormattingEnabled = true;
            this.cmb_Amount1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "Other"});
            this.cmb_Amount1.Location = new System.Drawing.Point(183, 126);
            this.cmb_Amount1.Name = "cmb_Amount1";
            this.cmb_Amount1.Size = new System.Drawing.Size(76, 21);
            this.cmb_Amount1.TabIndex = 9;
            this.cmb_Amount1.Text = "1";
            // 
            // cmb_Amount2
            // 
            this.cmb_Amount2.FormattingEnabled = true;
            this.cmb_Amount2.Items.AddRange(new object[] {
            "0",
            "1/4",
            "1/3",
            "1/2",
            "2/3",
            "3/4"});
            this.cmb_Amount2.Location = new System.Drawing.Point(292, 126);
            this.cmb_Amount2.Name = "cmb_Amount2";
            this.cmb_Amount2.Size = new System.Drawing.Size(87, 21);
            this.cmb_Amount2.TabIndex = 10;
            this.cmb_Amount2.Text = "1/3";
            // 
            // cmb_Units
            // 
            this.cmb_Units.FormattingEnabled = true;
            this.cmb_Units.Items.AddRange(new object[] {
            "Cup",
            "Tablespoon",
            "Teaspoon",
            "Gallon",
            "Oz",
            "Egg",
            "Box",
            "Lbs"});
            this.cmb_Units.Location = new System.Drawing.Point(183, 185);
            this.cmb_Units.Name = "cmb_Units";
            this.cmb_Units.Size = new System.Drawing.Size(115, 21);
            this.cmb_Units.TabIndex = 11;
            this.cmb_Units.Text = "Cups";
            // 
            // btn_AddIngredient
            // 
            this.btn_AddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddIngredient.Location = new System.Drawing.Point(151, 235);
            this.btn_AddIngredient.Name = "btn_AddIngredient";
            this.btn_AddIngredient.Size = new System.Drawing.Size(172, 26);
            this.btn_AddIngredient.TabIndex = 12;
            this.btn_AddIngredient.Text = "Add";
            this.btn_AddIngredient.UseVisualStyleBackColor = true;
            this.btn_AddIngredient.Click += new System.EventHandler(this.btn_AddIngredient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_IngredientName);
            this.groupBox1.Controls.Add(this.btn_AddIngredient);
            this.groupBox1.Controls.Add(this.cmb_Units);
            this.groupBox1.Controls.Add(this.cmb_Amount2);
            this.groupBox1.Controls.Add(this.cmb_Amount1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(17, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 302);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ingredient";
            // 
            // txt_IngredientName
            // 
            this.txt_IngredientName.Location = new System.Drawing.Point(183, 75);
            this.txt_IngredientName.Name = "txt_IngredientName";
            this.txt_IngredientName.Size = new System.Drawing.Size(196, 20);
            this.txt_IngredientName.TabIndex = 13;
            this.txt_IngredientName.Text = "Chocolate";
            // 
            // AddIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AddDirections);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Ingredients);
            this.Controls.Add(this.lbl_RecipeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_RecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddIngredientsForm";
            this.Text = "AddIngredients";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ingredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRecipeAppDBDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_RecipeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_RecipeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Ingredients;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_AddDirections;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Amount1;
        private System.Windows.Forms.ComboBox cmb_Amount2;
        private System.Windows.Forms.ComboBox cmb_Units;
        private System.Windows.Forms.Button btn_AddIngredient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_IngredientName;
        private System.Windows.Forms.BindingSource myRecipeAppDBDataSetBindingSource;
        
    }
}