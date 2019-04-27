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
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
           
        }
        

        private void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipe = new AddRecipeForm();
            this.Hide();
            addRecipe.ShowDialog();
            this.Close();
        }

        private void btn_BrowseRecipe_Click(object sender, EventArgs e)
        {
            BrowseRecipes browseRecipes = new BrowseRecipes();
            this.Hide();
            browseRecipes.ShowDialog();
            this.Close();
        }
    }
}
