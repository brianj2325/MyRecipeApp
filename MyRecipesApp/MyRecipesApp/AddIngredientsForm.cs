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
        string connectionString = @"Data Source = OfficeComputer\SQLEXPRESS; Initial Catalog = MyRecipeAppDB; Integrated Security=True;";
        DataTable recipeIngredientTable = new DataTable("ingredientsForRecipe");
        DataTable ingredientTable = new DataTable("ingredientTable");
        public DataSet RecipeDataSet;
        int ingredientID;

        public AddIngredientsForm(int recipeID, string recipeName, DataSet dataSet)
        {
            InitializeComponent();
            RecipeDataSet = dataSet;
            CreateTable();





            lbl_RecipeID.Text = recipeID.ToString();
            lbl_RecipeName.Text = recipeName;


        }

        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {

            updateTable();

            clearIngredient();
            DisplayIngredients();


        }

        private void clearIngredient()
        {
            txt_IngredientName.Text = "";
            cmb_Amount1.Text = "1";
            cmb_Amount2.Text = "0";
            cmb_Units.Text = "Cups";

        }
        public void AddRow()
        {

            double totalAmount = Convert.ToDouble(cmb_Amount1.Text) + FractionToDouble(cmb_Amount2.Text);

            DataRow row = RecipeDataSet.Tables["ingredientTable"].NewRow();
            row["ingredientID"] = GetIngredientID();
            row["ingredientName"] = txt_IngredientName.Text;
            row["ingredientAmount"] = totalAmount;
            row["ingredientUnits"] = cmb_Units.Text;
            row["recipeID"] = lbl_RecipeID.Text;

            ingredientTable.Rows.Add(row);

            updateTable();

        }

        public void CreateTable()
        {
            ingredientTable = RecipeDataSet.Tables.Add("ingredientTable");

            ingredientTable.Columns.Add("ingredientID", Type.GetType("System.Int32"));
            ingredientTable.Columns.Add("recipeID", Type.GetType("System.Int32"));
            ingredientTable.Columns.Add("ingredientName", Type.GetType("System.String"));
            ingredientTable.Columns.Add("ingredientAmount", Type.GetType("System.Double"));
            ingredientTable.Columns.Add("ingredientUnits", Type.GetType("System.String"));

        }

        private void updateTable()
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
                row["recipeID"] = lbl_RecipeID.Text;
                row["ingredientName"] = txt_IngredientName.Text;
                row["ingredientAmount"] = Convert.ToDouble(cmb_Amount1.Text) + FractionToDouble(cmb_Amount2.Text);
                row["ingredientUnits"] = cmb_Units.Text;
                RecipeDataSet.Tables["ingredientTable"].Rows.Add(row);

                new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ingredientTable);
                sqlConn.Close();
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
            if (recipeIngredientTable != null)
            {
                recipeIngredientTable.Clear();
            }
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                var sqlQuery = "select * from IngredientTable WHERE recipeID=" + lbl_RecipeID.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                dataAdapter.Fill(recipeIngredientTable);
            }




            
                dgv_Ingredients.DataSource = recipeIngredientTable;
                dgv_Ingredients.Columns["recipeID"].Visible = false;
                dgv_Ingredients.Columns["ingredientID"].Visible = false;
            
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
                updateTable();
            }
        
    }
}
