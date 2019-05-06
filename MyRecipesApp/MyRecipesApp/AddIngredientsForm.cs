using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyRecipesApp
{
    public partial class AddIngredientsForm : Form
    {
        string connectionString = @"Data Source=OfficeComputer\SQLEXPRESS;Initial Catalog=MyRecipeAppDB;Integrated Security=True;";
        DataTable recipeIngredientTable = new DataTable("recipeIngredientTable");
        DataTable ingredientTable = new DataTable("ingredientTable");
        public DataSet RecipeDataSet;
        int ingredientID;
        int rowControl = 4;
        int columnControl = 1;
        
        Recipe recipe;
        List<Ingredient> ingredients = new List<Ingredient>();
        List<Label> ingredientLabels = new List<Label>();
        List<Button> buttons = new List<Button>();
        


        public AddIngredientsForm(Recipe recipe, DataSet dataSet)
        {
            InitializeComponent();

            RecipeDataSet = dataSet;
            this.recipe = recipe;
            //frm = addRecipeForm;
            if (recipe.ingredients != null)
            {
                this.ingredients = recipe.ingredients;
                DisplayIngredients(); 
            }


            if (!dataSet.Tables.Contains("ingredientTable"))
            {

                CreateTable();
            }
            //CreateDisplayTable();

            lbl_RecipeID.Text = recipe.recipeID.ToString();

           
        }

        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient();

            //if (string.IsNullOrWhiteSpace(txt_IngredientName.Text))
            //{
            //    MessageBox.Show("Please enter an ingredient name");
            //}
            //else
            //{
                ingredient.ingredientName = txt_IngredientName.Text;

                if (cmb_Amount2.Text == "0")
                {
                    ingredient.amount = cmb_Amount1.Text;
                }
                else if (cmb_Amount1.Text == "0")
                {
                    ingredient.amount = cmb_Amount2.Text;
                }
                else
                {
                    ingredient.amount = cmb_Amount1.Text + " - " + cmb_Amount2.Text;
                }

                if (cmb_Units.Text == "Egg")
                {
                    ingredient.units = "";
                    ingredient.amount = cmb_Amount1.Text;
                }
                else
                { ingredient.units = cmb_Units.Text; }


                ingredients.Add(ingredient);


                clearIngredient();
                DisplayIngredients();
            //}


        }
        
        private void clearIngredient()
        {
            txt_IngredientName.Text = "";
            cmb_Amount1.Text = "1";
            cmb_Amount2.Text = "0";
            cmb_Units.Text = "Cups";

        }


        private void CreateTable()
        {
            ingredientTable = RecipeDataSet.Tables.Add("ingredientTable");

            ingredientTable.Columns.Add("ingredientID", Type.GetType("System.Int32"));
            ingredientTable.Columns.Add("recipeID", Type.GetType("System.Int32"));
            ingredientTable.Columns.Add("ingredientName", Type.GetType("System.String"));
            ingredientTable.Columns.Add("ingredientAmount", Type.GetType("System.String"));
            ingredientTable.Columns.Add("ingredientUnits", Type.GetType("System.String"));

        }

        private void updateTable(List<Ingredient> ingredients)
        {
            foreach (Ingredient ingredient in ingredients)
            {


                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {

                    sqlConn.Open();
                    var sqlQuery = "select * from IngredientTable";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                    dataAdapter.Fill(ingredientTable);
                    DataRow row = RecipeDataSet.Tables["ingredientTable"].NewRow();
                    ingredientID = GetIngredientID();


                    row["ingredientID"] = ingredientID;
                    row["recipeID"] = recipe.recipeID;
                    row["ingredientName"] = ingredient.ingredientName;
                    row["ingredientAmount"] = ingredient.amount;
                    row["ingredientUnits"] = ingredient.units;
                    RecipeDataSet.Tables["ingredientTable"].Rows.Add(row);

                    new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(ingredientTable);
                    sqlConn.Close();
                }
            }

        }


        public int GetIngredientID()
        {

            if (ingredientTable != null)
            {
                if (ingredientTable.Rows.Count > 0)
                {
                    ingredientID = Convert.ToInt32(ingredientTable.Rows[ingredientTable.Rows.Count - 1]["ingredientID"]);
                    ingredientID++;

                }

                else
                {
                    ingredientID = 1;
                }


            }

            return ingredientID;
        }

        private void DisplayIngredients()
        {
            int r = rowControl;
            int c = columnControl;
            
            
           foreach (Ingredient i in ingredients)
            {
                string ingredientString = i.amount + " " + i.units + " " + i.ingredientName;
                if (r > 15)
                {
                    if (c == 350)
                    { break; }
                    else
                    {
                        r = 4;
                        c = 350;
                    }
                    
                }

                else
                {
                    CreateLabel(ingredientString, "lbl_Ingredient", r, c);
                    CreateButton("Delete", r, c + 250, i);
                    r++;

                }
    
            }
            
      
            
        }

        public void CreateLabel(string labelText,string labelName, int x, int y)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Name = labelName + x.ToString();
            label.Top = x * 25;
            label.Left = y;
            label.Text = labelText;
            label.AutoSize = true;
            label.MaximumSize = new Size(300, 0);
            ingredientLabels.Add(label);

        }

        public void ClearLabels()
        {
            foreach (Label label in ingredientLabels)
            {
                this.Controls.Remove(label);
            }
            foreach (Button button in buttons)
            {
                this.Controls.Remove(button);
            }

            
        }
        public void CreateButton(string buttonText, int x, int y, Ingredient ingredient)
        {
            Button button = new Button();
            this.Controls.Add(button);
            button.Name = buttonText + x.ToString();
            button.Top = x * 25;
            button.Left = y;
            button.Text = buttonText;
            button.AutoSize = true;
            button.Click += (sender, args) =>
            {
                var labelToRemove = this.Controls["lbl_Ingredient"];
                
                this.Controls.Remove(labelToRemove);
                var buttonToRemove = this.Controls[buttonText+x.ToString()];
                this.Controls.Remove(buttonToRemove);
                ingredients.Remove(ingredient);
                ClearLabels();
                DisplayIngredients();
                
                
            };
            buttons.Add(button);

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

                if (split.Length == 1 || split.Length == 2 || split.Length == 3)
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

            private void btn_Cancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btn_AddDirections_Click(object sender, EventArgs e)
            {
            recipe.ingredients = ingredients;
            updateTable(ingredients);
            AddDirectionsForm addDirectionsForm = new AddDirectionsForm(recipe, RecipeDataSet);
            this.Hide();
            addDirectionsForm.ShowDialog();
            this.Close();
            }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipe = new AddRecipeForm(recipe);
            this.Hide();
            addRecipe.ShowDialog();
            this.Close();
            this.Hide();
            //frm.Show();
        }
    }
}
