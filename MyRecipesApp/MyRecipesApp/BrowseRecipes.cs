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
        Recipe recipe = new Recipe();
        ViewRecipeForm viewRecipe;



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

            DisplayRecipes(recipes);


            



        }

        public void DisplayRecipes(DataTable dataTable)
        {
            dgv_BrowseRecipes.DataSource = dataTable;
            dgv_BrowseRecipes.ReadOnly = true;
            dgv_BrowseRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_BrowseRecipes.MultiSelect = false;

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
                string search = "%" + txt_SearchBox.Text + "%";
                var sqlQuery = "select * from RecipeTable WHERE recipeName LIKE @search";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                cmd.Parameters.AddWithValue("search", search);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);


                dataAdapter.Fill(recipes);
            }


            DisplayRecipes(recipes);
        }

        private void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm(null);
            this.Hide();
            addRecipeForm.ShowDialog();
            this.Close();
        }

        private void btn_ViewRecipe_Click(object sender, EventArgs e)
        {
            if (dgv_BrowseRecipes.SelectedRows.Count > 0)
            {
                int recipeID;
                recipeID = Convert.ToInt32(dgv_BrowseRecipes.CurrentRow.Cells[0].Value);
                recipe = GetRecipe(recipeID);
                viewRecipe = new ViewRecipeForm(recipe, null);
                this.Hide();
                viewRecipe.ShowDialog();
                this.Close();

                
                
                

            }
            
        }

        private Recipe GetRecipe(int recipeID)
        {
            
            recipe.recipeID = recipeID;
            List<Ingredient> ingredients = new List<Ingredient>();
            List<Directions> directions = new List<Directions>();

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                
                var sqlQueryRecipeTable = "select * from RecipeTable WHERE recipeID=" + recipe.recipeID.ToString();
                SqlCommand myCommandRecipeTable = new SqlCommand(sqlQueryRecipeTable, sqlConn);
                SqlDataReader myReaderRecipeTable = myCommandRecipeTable.ExecuteReader();
                while (myReaderRecipeTable.Read())
                {
                    recipe.recipeName = myReaderRecipeTable["recipeName"].ToString();
                    recipe.category = myReaderRecipeTable["recipeCategory"].ToString();
                    recipe.description = myReaderRecipeTable["recipeDescription"].ToString();
                }

                sqlConn.Close();

                sqlConn.Open();
                var sqlQueryCookInfo = "select * from CookInfoTable WHERE recipeID=" + recipe.recipeID.ToString();
                SqlCommand myCommandCookInfo = new SqlCommand(sqlQueryCookInfo, sqlConn);
                SqlDataReader myReaderCookInfo = myCommandCookInfo.ExecuteReader();
                while (myReaderCookInfo.Read())
                {
                    recipe.ovenTemp = Convert.ToInt32(myReaderCookInfo["ovenTemp"]);
                    recipe.prepTimeHours = Convert.ToInt32(myReaderCookInfo["prepTimeHours"]);
                    recipe.prepTimeMinutes = Convert.ToInt32(myReaderCookInfo["prepTimeMinutes"]);
                    recipe.cookTimeHours = Convert.ToInt32(myReaderCookInfo["cookTimeHours"]);
                    recipe.cookTimeMinutes = Convert.ToInt32(myReaderCookInfo["cookTimeMinutes"]);

                }

                sqlConn.Close();


                sqlConn.Open();

                var sqlQueryIngredientTable = "select * from IngredientTable WHERE recipeID=" + recipe.recipeID.ToString();
                SqlCommand myCommandIngredientTable = new SqlCommand(sqlQueryIngredientTable, sqlConn);
                SqlDataReader myReaderIngredientTable = myCommandIngredientTable.ExecuteReader();
                while (myReaderIngredientTable.Read())
                {
                    Ingredient ingredient = new Ingredient();
                    ingredient.ingredientName = myReaderIngredientTable["ingredientName"].ToString();
                    ingredient.amount = myReaderIngredientTable["ingredientAmount"].ToString();
                    ingredient.units = myReaderIngredientTable["ingredientUnits"].ToString();
                    ingredients.Add(ingredient);
                    
                }

                sqlConn.Close();

                recipe.ingredients = ingredients;


                sqlConn.Open();

                var sqlQueryDirections = "select * from DirectionTable WHERE recipeID=" + recipe.recipeID;
                SqlCommand myCommandDirections = new SqlCommand(sqlQueryDirections, sqlConn);
                SqlDataReader myReaderDirections = myCommandDirections.ExecuteReader();
                while (myReaderDirections.Read())
                {
                    Directions direction = new Directions();
                    direction.directionNumber = Convert.ToInt32(myReaderDirections["directionNumber"]);
                    direction.direction = myReaderDirections["direction"].ToString();
                    directions.Add(direction);

                }

                sqlConn.Close();

                recipe.directions = directions;

                return recipe;

            }
        }
        
    }
}
