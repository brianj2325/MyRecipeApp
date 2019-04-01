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
        string connectionString = @"Data Source = OfficeComputer\SQLEXPRESS; Initial Catalog = MyRecipeAppDB; Integrated Security=True;";
        DataSet recipeData = new DataSet("RecipeData");
        DataTable recipeTable = new DataTable("recipeTable");
        int recipeID;
        
        

        public AddRecipeForm()
        {
            InitializeComponent();
          
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            updateTable();
            
               
            AddIngredientsForm addIngredientsForm = new AddIngredientsForm(recipeID, txt_RecipeName.Text, recipeData);
            addIngredientsForm.RecipeDataSet = this.recipeData;
            this.Hide();
            addIngredientsForm.ShowDialog();
            this.Close();
        }

        


        private void updateTable()
        {
            recipeTable = recipeData.Tables.Add("recipeTable");
            CreateTable();

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                var sqlQuery = "select * from RecipeTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                
                dataAdapter.Fill(recipeTable);
                DataRow row = recipeData.Tables["recipeTable"].NewRow();
                
                row["recipeID"] = GetRecipeID();
                row["recipeName"] = txt_RecipeName.Text;
                row["recipeCategory"] = cmb_Category.Text;
                row["recipeDescription"] = txt_Description.Text;
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
            this.Close();
        }


    }




}