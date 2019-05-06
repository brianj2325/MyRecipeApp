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
    public partial class AddRecipeForm : Form
    {
        string connectionString = @"Data Source=OfficeComputer\SQLEXPRESS;Initial Catalog=MyRecipeAppDB;Integrated Security=True;";
        DataSet recipeData = new DataSet("RecipeData");
        DataTable recipeTable = new DataTable("recipeTable");
        int recipeID;
        Recipe recipe = new Recipe();
        



        public AddRecipeForm(Recipe recipe)
        {
            InitializeComponent();
            //ingredientsForm = new AddIngredientsForm(this);
            if (recipe != null)
            {
                txt_RecipeName.Text = recipe.recipeName;
                txt_Description.Text = recipe.description;
                cmb_Category.Text = recipe.category;
            }

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            recipe = CreateRecipe();
            updateTable();
            recipe.recipeID = recipeID;
            
            

            AddIngredientsForm addIngredientsForm = new AddIngredientsForm(recipe, recipeData);
            //addIngredientsForm.RecipeDataSet = this.recipeData;
            this.Hide();
            //ingredientsForm.Show();
            addIngredientsForm.ShowDialog();
            this.Close();
        }

        private Recipe CreateRecipe()
        {
            
            //Recipe.recipeID = GetRecipeID();
            recipe.recipeName = txt_RecipeName.Text;
            recipe.category = cmb_Category.Text;
            recipe.description = txt_Description.Text;

            return recipe;

        }


        private void updateTable()
        {
            if (!recipeData.Tables.Contains("recipeTable"))
            {
                recipeTable = recipeData.Tables.Add("recipeTable");
                CreateTable();
            }
            
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                var sqlQuery = "select * from RecipeTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                dataAdapter.Fill(recipeTable);

                recipeID = GetRecipeID();
                DataRow row = recipeData.Tables["recipeTable"].NewRow();

                row["recipeID"] = recipeID;
                row["recipeName"] = recipe.recipeName;
                row["recipeCategory"] = recipe.category;
                row["recipeDescription"] = recipe.description;
                recipeData.Tables["recipeTable"].Rows.Add(row);

                new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(recipeTable);
                sqlConn.Close();
            }


        }

        public void CreateTable()
        {

            recipeTable.Columns.Add("recipeID", Type.GetType("System.Int32"));
            recipeTable.Columns.Add("recipeName", Type.GetType("System.String"));
            recipeTable.Columns.Add("recipeCategory", Type.GetType("System.String"));
            recipeTable.Columns.Add("recipeDescription", Type.GetType("System.String"));

        }

        public void PopulateDatabase()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            using (var sqlBulk = new SqlBulkCopy(connectionString))
            {
                sqlBulk.DestinationTableName = "RecipeTable";
                sqlBulk.WriteToServer(recipeTable);
            }
        }



        public int GetRecipeID()
        {
            if (recipeTable != null)
            {
                if (recipeTable.Rows.Count > 0)
                {
                    

                    recipeID = Convert.ToInt32(recipeTable.Rows[recipeTable.Rows.Count-1]["recipeID"]);
                    recipeID++;

                }

                else
                {
                    recipeID = 1;
                }

            }

            return recipeID;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }


    }




}