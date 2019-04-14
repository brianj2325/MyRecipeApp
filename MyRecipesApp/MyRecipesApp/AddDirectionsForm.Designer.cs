namespace MyRecipesApp
{
    partial class AddDirectionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Directions = new System.Windows.Forms.TextBox();
            this.btn_AddDirection = new System.Windows.Forms.Button();
            this.btn_Review = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Directions = new System.Windows.Forms.DataGridView();
            this.lbl_RecipeID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_RecipeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_PrepHours = new System.Windows.Forms.ComboBox();
            this.cmb_OvenTemp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_PrepMinutes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_CookHours = new System.Windows.Forms.ComboBox();
            this.cmb_CookMinutes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Directions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Directions);
            this.groupBox1.Controls.Add(this.btn_AddDirection);
            this.groupBox1.Location = new System.Drawing.Point(28, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 202);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Direction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter one step at a time and click \"Add Step\" to add the instruction";
            // 
            // txt_Directions
            // 
            this.txt_Directions.Location = new System.Drawing.Point(28, 61);
            this.txt_Directions.Multiline = true;
            this.txt_Directions.Name = "txt_Directions";
            this.txt_Directions.Size = new System.Drawing.Size(348, 88);
            this.txt_Directions.TabIndex = 13;
            this.txt_Directions.Text = "Pour in bowl";
            // 
            // btn_AddDirection
            // 
            this.btn_AddDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDirection.Location = new System.Drawing.Point(115, 167);
            this.btn_AddDirection.Name = "btn_AddDirection";
            this.btn_AddDirection.Size = new System.Drawing.Size(172, 26);
            this.btn_AddDirection.TabIndex = 12;
            this.btn_AddDirection.Text = "Add Direction";
            this.btn_AddDirection.UseVisualStyleBackColor = true;
            this.btn_AddDirection.Click += new System.EventHandler(this.btn_AddDirection_Click);
            // 
            // btn_Review
            // 
            this.btn_Review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Review.Location = new System.Drawing.Point(464, 403);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(150, 33);
            this.btn_Review.TabIndex = 28;
            this.btn_Review.Text = "Review";
            this.btn_Review.UseVisualStyleBackColor = true;
            this.btn_Review.Click += new System.EventHandler(this.btn_Review_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(349, 403);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(92, 33);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(174, 403);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 33);
            this.btn_Back.TabIndex = 26;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "List of Directions for:";
            // 
            // dgv_Directions
            // 
            this.dgv_Directions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Directions.Location = new System.Drawing.Point(433, 146);
            this.dgv_Directions.Name = "dgv_Directions";
            this.dgv_Directions.Size = new System.Drawing.Size(339, 215);
            this.dgv_Directions.TabIndex = 24;
            // 
            // lbl_RecipeID
            // 
            this.lbl_RecipeID.AutoSize = true;
            this.lbl_RecipeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecipeID.Location = new System.Drawing.Point(672, 123);
            this.lbl_RecipeID.Name = "lbl_RecipeID";
            this.lbl_RecipeID.Size = new System.Drawing.Size(100, 24);
            this.lbl_RecipeID.TabIndex = 23;
            this.lbl_RecipeID.Text = "123456789";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Recipe ID:";
            // 
            // lbl_RecipeName
            // 
            this.lbl_RecipeName.AutoSize = true;
            this.lbl_RecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecipeName.Location = new System.Drawing.Point(574, 99);
            this.lbl_RecipeName.Name = "lbl_RecipeName";
            this.lbl_RecipeName.Size = new System.Drawing.Size(198, 24);
            this.lbl_RecipeName.TabIndex = 21;
            this.lbl_RecipeName.Text = "this is the recipe name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Recipe Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add Directions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Oven Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Prep Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cook Time";
            // 
            // cmb_PrepHours
            // 
            this.cmb_PrepHours.FormattingEnabled = true;
            this.cmb_PrepHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmb_PrepHours.Location = new System.Drawing.Point(200, 73);
            this.cmb_PrepHours.Name = "cmb_PrepHours";
            this.cmb_PrepHours.Size = new System.Drawing.Size(38, 21);
            this.cmb_PrepHours.TabIndex = 33;
            this.cmb_PrepHours.Text = "1";
            // 
            // cmb_OvenTemp
            // 
            this.cmb_OvenTemp.FormattingEnabled = true;
            this.cmb_OvenTemp.Items.AddRange(new object[] {
            "200",
            "225",
            "250",
            "275",
            "300",
            "325",
            "350",
            "375",
            "400",
            "425",
            "450",
            "475",
            "500"});
            this.cmb_OvenTemp.Location = new System.Drawing.Point(200, 128);
            this.cmb_OvenTemp.Name = "cmb_OvenTemp";
            this.cmb_OvenTemp.Size = new System.Drawing.Size(79, 21);
            this.cmb_OvenTemp.TabIndex = 33;
            this.cmb_OvenTemp.Text = "375";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Hours";
            // 
            // cmb_PrepMinutes
            // 
            this.cmb_PrepMinutes.FormattingEnabled = true;
            this.cmb_PrepMinutes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmb_PrepMinutes.Location = new System.Drawing.Point(286, 73);
            this.cmb_PrepMinutes.Name = "cmb_PrepMinutes";
            this.cmb_PrepMinutes.Size = new System.Drawing.Size(38, 21);
            this.cmb_PrepMinutes.TabIndex = 33;
            this.cmb_PrepMinutes.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Minutes";
            // 
            // cmb_CookHours
            // 
            this.cmb_CookHours.FormattingEnabled = true;
            this.cmb_CookHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmb_CookHours.Location = new System.Drawing.Point(200, 99);
            this.cmb_CookHours.Name = "cmb_CookHours";
            this.cmb_CookHours.Size = new System.Drawing.Size(38, 21);
            this.cmb_CookHours.TabIndex = 33;
            this.cmb_CookHours.Text = "2";
            // 
            // cmb_CookMinutes
            // 
            this.cmb_CookMinutes.FormattingEnabled = true;
            this.cmb_CookMinutes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmb_CookMinutes.Location = new System.Drawing.Point(286, 99);
            this.cmb_CookMinutes.Name = "cmb_CookMinutes";
            this.cmb_CookMinutes.Size = new System.Drawing.Size(38, 21);
            this.cmb_CookMinutes.TabIndex = 33;
            this.cmb_CookMinutes.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Hours";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Minutes";
            // 
            // AddDirectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_OvenTemp);
            this.Controls.Add(this.cmb_CookMinutes);
            this.Controls.Add(this.cmb_PrepMinutes);
            this.Controls.Add(this.cmb_CookHours);
            this.Controls.Add(this.cmb_PrepHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Review);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Directions);
            this.Controls.Add(this.lbl_RecipeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_RecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDirectionsForm";
            this.Text = "AddDirectionsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Directions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddDirection;
        private System.Windows.Forms.Button btn_Review;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Directions;
        private System.Windows.Forms.Label lbl_RecipeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_RecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Directions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_PrepHours;
        private System.Windows.Forms.ComboBox cmb_OvenTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_PrepMinutes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_CookHours;
        private System.Windows.Forms.ComboBox cmb_CookMinutes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}