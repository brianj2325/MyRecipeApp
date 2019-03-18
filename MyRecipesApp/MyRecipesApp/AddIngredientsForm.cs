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
    public partial class AddIngredientsForm : Form
    {
        public AddIngredientsForm(string recipeId,string recipeName)
        {
            InitializeComponent();
            lbl_RecipeID.Text = recipeId;
            lbl_RecipeName.Text = recipeName;

        }

        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {
            RecipeDataSet ds = new RecipeDataSet();
            double totalAmount = Convert.ToDouble(cmb_Amount1.Text) + FractionToDouble(cmb_Amount2.Text);

            DataRow row = ds.Tables["RecipeIngredientTable"].NewRow();
            row["amount"] = totalAmount;
            row["unitsOfIngredient"] = cmb_Units.Text;
            
            ds.RecipeIngredientTable.Rows.Add(row);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        double FractionToDouble(string fraction)
        {
            double result;

            if (double.TryParse(fraction, out result))
            {
                return result;
            }

            //string[] split = fraction.Split(new char[] { ' ', '/' });
            string[] split = fraction.Split('/');

            if (split.Length == 1|| split.Length == 2 || split.Length == 3)
            {
                int a, b;

                if (int.TryParse(split[0], out a) && int.TryParse(split[1], out b))
                {
                    if (split.Length == 2)
                    {
                        return (double)a / b;
                    }

                    int c;

                    if (int.TryParse(split[2], out c))
                    {
                        return a + (double)b / c;
                    }
                }
            }

            throw new FormatException("Not a valid fraction.");
        }


    }
}
