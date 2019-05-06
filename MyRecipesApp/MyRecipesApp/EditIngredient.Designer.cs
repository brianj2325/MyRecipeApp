namespace MyRecipesApp
{
    partial class EditIngredient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_editIngredientName = new System.Windows.Forms.TextBox();
            this.cmb_editIngredientAmount1 = new System.Windows.Forms.ComboBox();
            this.cmb_editIngredientAmount2 = new System.Windows.Forms.ComboBox();
            this.cmb_editUnits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units";
            // 
            // txt_editIngredientName
            // 
            this.txt_editIngredientName.Location = new System.Drawing.Point(175, 67);
            this.txt_editIngredientName.Name = "txt_editIngredientName";
            this.txt_editIngredientName.Size = new System.Drawing.Size(197, 20);
            this.txt_editIngredientName.TabIndex = 3;
            // 
            // cmb_editIngredientAmount1
            // 
            this.cmb_editIngredientAmount1.FormattingEnabled = true;
            this.cmb_editIngredientAmount1.Location = new System.Drawing.Point(175, 123);
            this.cmb_editIngredientAmount1.Name = "cmb_editIngredientAmount1";
            this.cmb_editIngredientAmount1.Size = new System.Drawing.Size(59, 21);
            this.cmb_editIngredientAmount1.TabIndex = 4;
            // 
            // cmb_editIngredientAmount2
            // 
            this.cmb_editIngredientAmount2.FormattingEnabled = true;
            this.cmb_editIngredientAmount2.Location = new System.Drawing.Point(272, 123);
            this.cmb_editIngredientAmount2.Name = "cmb_editIngredientAmount2";
            this.cmb_editIngredientAmount2.Size = new System.Drawing.Size(61, 21);
            this.cmb_editIngredientAmount2.TabIndex = 5;
            // 
            // cmb_editUnits
            // 
            this.cmb_editUnits.FormattingEnabled = true;
            this.cmb_editUnits.Location = new System.Drawing.Point(177, 177);
            this.cmb_editUnits.Name = "cmb_editUnits";
            this.cmb_editUnits.Size = new System.Drawing.Size(120, 21);
            this.cmb_editUnits.TabIndex = 6;
            // 
            // EditIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 287);
            this.Controls.Add(this.cmb_editUnits);
            this.Controls.Add(this.cmb_editIngredientAmount2);
            this.Controls.Add(this.cmb_editIngredientAmount1);
            this.Controls.Add(this.txt_editIngredientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditIngredient";
            this.Text = "EditIngredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_editIngredientName;
        private System.Windows.Forms.ComboBox cmb_editIngredientAmount1;
        private System.Windows.Forms.ComboBox cmb_editIngredientAmount2;
        private System.Windows.Forms.ComboBox cmb_editUnits;
    }
}