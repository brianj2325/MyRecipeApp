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
    public partial class BrowseRecipes : Form
    {

        string connectionString = @"Data Source=OfficeComputer\SQLEXPRESS;Initial Catalog=MyRecipeAppDB;Integrated Security=True;";

        DataTable recipes = new DataTable("Recipes");


        public BrowseRecipes()
        {
            InitializeComponent();
            
            
        }

        private void Browse()
        {
           
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();

                var sqlQuery = "select * from RecipeTable WHERE recipeCategory=@category";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                cmd.Parameters.AddWithValue("category", cmb_BrowseCategory.SelectedItem.ToString());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                

                dataAdapter.Fill(recipes);
            }


            dgv_BrowseRecipes.DataSource = recipes;


        }

        //public void CreateTable()
        //{
        //    recipes.Columns.Add("recipeName", Type.GetType("System.String"));
        //    recipes.Columns.Add("recipeDescription", Type.GetType("System.String"));
            
        //}
    
        private void  cmb_BrowseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipes != null)
            {
                recipes.Clear();
            }
            Browse();
        }

        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (recipes != null)
            {
                recipes.Clear();
            }
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                string search = txt_SearchBox.Text + "%";
                var sqlQuery = "select * from RecipeTable WHERE recipeName LIKE @search";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                cmd.Parameters.AddWithValue("search", search);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);


                dataAdapter.Fill(recipes);
            }


            dgv_BrowseRecipes.DataSource = recipes;
            dgv_BrowseRecipes.AutoResizeColumn(4);
        }

        private void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm();
            this.Hide();
            addRecipeForm.ShowDialog();
            this.Close();
        }
    }
}
