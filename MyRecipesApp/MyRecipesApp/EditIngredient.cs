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
    public partial class EditIngredient : Form
    {
        public EditIngredient(Ingredient ingredient)
        {
            InitializeComponent();

            txt_editIngredientName.Text = ingredient.ingredientName;
            cmb_editIngredientAmount1.Text = ingredient.amount1.ToString();
            cmb_editIngredientAmount2.Text = ingredient.amount2.ToString();
        }
    }
}
