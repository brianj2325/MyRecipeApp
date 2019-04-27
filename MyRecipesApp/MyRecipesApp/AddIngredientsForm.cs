﻿using System;
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
        
        Recipe recipe;
        List<Ingredient> ingredients = new List<Ingredient>();


        public AddIngredientsForm(Recipe recipe, DataSet dataSet)
        {
            InitializeComponent();

            RecipeDataSet = dataSet;
            this.recipe = recipe;
            
           

            CreateTable();
            CreateDisplayTable();

            lbl_RecipeID.Text = recipe.recipeID.ToString();

            lbl_RecipeName.Text = recipe.recipeName;
        }

        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient();

            
            ingredient.ingredientName = txt_IngredientName.Text;
           
            if (cmb_Amount2.Text == "0")
            {
                ingredient.amount = cmb_Amount1.Text;
            }
            else
            {
                ingredient.amount = cmb_Amount1.Text + " - " + cmb_Amount2.Text;
            }
            
            ingredient.units = cmb_Units.Text;
            ingredients.Add(ingredient);
            updateTable(ingredient);

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
        //private void AddRow()
        //{

        //    double totalAmount = Convert.ToDouble(cmb_Amount1.Text) + FractionToDouble(cmb_Amount2.Text);

        //    DataRow row = RecipeDataSet.Tables["ingredientTable"].NewRow();
        //    row["ingredientID"] = GetIngredientID();
        //    row["ingredientName"] = txt_IngredientName.Text;
        //    row["ingredientAmount"] = totalAmount;
        //    row["ingredientUnits"] = cmb_Units.Text;
        //    row["recipeID"] = lbl_RecipeID.Text;

        //    ingredientTable.Rows.Add(row);

        //    updateTable();

        //}

        private void CreateTable()
        {
            ingredientTable = RecipeDataSet.Tables.Add("ingredientTable");

            ingredientTable.Columns.Add("ingredientID", Type.GetType("System.Int32"));
            ingredientTable.Columns.Add("recipeID", Type.GetType("System.Int32"));
            ingredientTable.Columns.Add("ingredientName", Type.GetType("System.String"));
            ingredientTable.Columns.Add("ingredientAmount", Type.GetType("System.String"));
            ingredientTable.Columns.Add("ingredientUnits", Type.GetType("System.String"));

        }

        private void updateTable(Ingredient ingredient)
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

        public void CreateDisplayTable()
        {
            recipeIngredientTable.Columns.Add("ingredientID", Type.GetType("System.Int32"));
            recipeIngredientTable.Columns.Add("recipeID", Type.GetType("System.Int32"));
            recipeIngredientTable.Columns.Add("ingredientName", Type.GetType("System.String"));
            recipeIngredientTable.Columns.Add("ingredientAmount", Type.GetType("System.String"));
            recipeIngredientTable.Columns.Add("ingredientUnits", Type.GetType("System.String"));
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
                var sqlQuery = "select * from IngredientTable WHERE recipeID=" + recipe.recipeID;
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
            recipe.ingredients = ingredients;
            AddDirectionsForm addDirectionsForm = new AddDirectionsForm(recipe, RecipeDataSet);
            this.Hide();
            addDirectionsForm.ShowDialog();
            this.Close();
            }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //AddRecipeForm addRecipe;
            //this.Hide();
            //addRecipe.ShowDialog();
            //this.Close();
        }
    }
}
