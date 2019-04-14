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
    public partial class RecipeReview : Form
    {
        int recipeID;

        DataSet RecipeDataSet;

        public RecipeReview(int recipeID, DataSet dataSet)
        {
            InitializeComponent();
            
            this.recipeID = recipeID;
          
            RecipeDataSet = dataSet;

            lbl_RecipeID.Text = recipeID.ToString();
            

            DisplayRecipeInfo();

        }

        private void DisplayRecipeInfo()
        {
           


        }

       

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
