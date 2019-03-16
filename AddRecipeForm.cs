using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecipesApp
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            RecipeDataSet ds = new RecipeDataSet();

            DataRow row = ds.Tables["recipeTable"].NewRow();
            row["recipeName"] = txt_RecipeName.Text;
            row["recipeCategory"] = cmb_Category.Text;
            row["recipeDescription"] = txt_Description.Text;
            ds.RecipeTable.Rows.Add(row);

            AddIngredientsForm addIngredientsForm = new AddIngredientsForm(row["recipeID"].ToString(),txt_RecipeName.Text);
            this.Hide();
            addIngredientsForm.ShowDialog();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }

    

    
}
