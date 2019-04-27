namespace MyRecipesApp
{
    partial class ViewRecipeForm
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
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_ExportToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(218, 600);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(112, 29);
            this.btn_Done.TabIndex = 0;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_ExportToFile
            // 
            this.btn_ExportToFile.Location = new System.Drawing.Point(379, 600);
            this.btn_ExportToFile.Name = "btn_ExportToFile";
            this.btn_ExportToFile.Size = new System.Drawing.Size(114, 29);
            this.btn_ExportToFile.TabIndex = 1;
            this.btn_ExportToFile.Text = "Export to File";
            this.btn_ExportToFile.UseVisualStyleBackColor = true;
            this.btn_ExportToFile.Click += new System.EventHandler(this.btn_ExportToFile_Click);
            // 
            // ViewRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 641);
            this.Controls.Add(this.btn_ExportToFile);
            this.Controls.Add(this.btn_Done);
            this.Name = "ViewRecipeForm";
            this.Text = "ViewRecipeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_ExportToFile;
    }
}