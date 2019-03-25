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
              
            // Add recipeTable to recipeData dataset
            recipeTable = recipeData.Tables.Add("recipeTable");
            // Fill recipeTable with recipes from SQL database
            recipeTable = fillDataTable(recipeTable);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            
            //string recipeID="";
            AddRow();

            PopulateDatabase();
            
               
            AddIngredientsForm addIngredientsForm = new AddIngredientsForm(recipeID, txt_RecipeName.Text);
            this.Hide();
            addIngredientsForm.ShowDialog();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public DataTable fillDataTable(DataTable table)
        {
            
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                string query = "SELECT * FROM [" + table + "] ORDER BY recipeID DESC";
                

                SqlCommand cmd = new SqlCommand(query, sqlConn);

                
                using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                {
                    a.Fill(recipeTable);
                    sqlConn.Close();
                    return recipeTable;
                }
            }

         
        }

        public void clearDatabase()
        {

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
        
        public void AddRow()
        {
            DataRow row = recipeData.Tables["recipeTable"].NewRow();

            row["recipeID"] = GetRecipeID()+1;
            row["recipeName"] = txt_RecipeName.Text;
            row["recipeCategory"] = cmb_Category.Text;
            row["recipeDescription"] = txt_Description.Text;
            recipeTable.Rows.Add(row);

        }

        public int GetRecipeID()
        {
            if (recipeTable != null)
            {
                if (recipeTable.Rows.Count > 0)
                {
                    recipeID = Convert.ToInt32(recipeTable.Rows[0]["recipeID"]);

                }

                else
                {
                    recipeID = 1;
                }

            }
          
                   
            
            
            return recipeID;
        }




    }




}