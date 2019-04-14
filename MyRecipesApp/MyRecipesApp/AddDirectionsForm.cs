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
    public partial class AddDirectionsForm : Form
    {
        
        DataSet RecipeDataSet;
        DataTable directionsTable = new DataTable("directionsTable");
        DataTable cookInfoTable = new DataTable("directionInfoTable");
        DataTable directionsForRecipeTable = new DataTable("directionsForRecipeTable");
        string connectionString = @"Data Source = OfficeComputer\SQLEXPRESS; Initial Catalog = MyRecipeAppDB; Integrated Security=True;";
        int recipeID, directionID;
        string recipeName;

        public AddDirectionsForm(int recipeID, string recipeName, DataSet dataSet)
        {
            InitializeComponent();
           
            
            RecipeDataSet = dataSet;
            this.recipeID = recipeID;
            this.recipeName = recipeName;
           

            CreateDirectionsTable();
            CreateCookInfoTable();

            lbl_RecipeID.Text = recipeID.ToString();
            lbl_RecipeName.Text = recipeName;

        }

        private void DisplayDirections()
        {
            if (directionsForRecipeTable != null)
            {
                directionsForRecipeTable.Clear();
            }
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                var sqlQuery = "select * from DirectionTable WHERE recipeID=" + lbl_RecipeID.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                dataAdapter.Fill(directionsForRecipeTable);
            }


            dgv_Directions.DataSource = directionsForRecipeTable;
            dgv_Directions.Columns["recipeID"].Visible = false;
            dgv_Directions.Columns["directionID"].Visible = false;

        }

        private void btn_AddDirection_Click(object sender, EventArgs e)
        {
            updateDirectionTable();
            DisplayDirections();
            txt_Directions.Text = "";
            
        }

        private void btn_Review_Click(object sender, EventArgs e)
        {
            updateCookInfoTable();
            RecipeReview reviewRecipe = new RecipeReview(recipeID,RecipeDataSet);
            this.Hide();
            reviewRecipe.ShowDialog();
            this.Close();

        }
        private void updateCookInfoTable()
        {
            

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                var sqlQuery = "select * from CookInfoTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                dataAdapter.Fill(cookInfoTable);
                DataRow row = RecipeDataSet.Tables["cookInfoTable"].NewRow();

                row["cookInfoID"] = GetTableID(cookInfoTable,"cookInfoID");
                row["recipeID"] = lbl_RecipeID.Text;
                row["prepTimeHours"] = cmb_PrepHours.Text;
                row["prepTimeMinutes"] = cmb_PrepMinutes.Text;
                row["cookTimeHours"] = cmb_CookHours.Text;
                row["cookTimeMinutes"] = cmb_CookMinutes.Text;
                row["ovenTemp"] = cmb_OvenTemp.Text;
                
                RecipeDataSet.Tables["cookInfoTable"].Rows.Add(row);

                new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(cookInfoTable);
                sqlConn.Close();
            }

        }

        
        private void updateDirectionTable()
        {

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                var sqlQuery = "select * from DirectionTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                dataAdapter.Fill(directionsTable);
                DataRow row = RecipeDataSet.Tables["directionsTable"].NewRow();
                directionID = GetTableID(directionsTable,"directionID");

                row["directionID"] = directionID;
                row["recipeID"] = lbl_RecipeID.Text;
                row["directionNumber"] = GetDirectionNumber();
                row["direction"] = txt_Directions.Text;
                
                RecipeDataSet.Tables["directionsTable"].Rows.Add(row);

                new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(directionsTable);
                sqlConn.Close();
            }

        }
        
        private int GetTableID(DataTable table, string tableID)
        {

            int ID = 0;

                if (table != null)
                {
                    if (table.Rows.Count > 0)
                    {
                        ID = Convert.ToInt32(table.Rows[table.Rows.Count - 1][tableID]);
                        ID++;

                    }

                    else
                    {
                        ID = 1;
                    }


                }

                return ID;
            
        }

        private int GetDirectionNumber()
        {
            int directionNumber = 0;
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                var sqlQuery = "select * from DirectionTable WHERE recipeID=" + lbl_RecipeID.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                dataAdapter.Fill(directionsTable);

            }

                if (directionsForRecipeTable != null)
                {
                    if (directionsForRecipeTable.Rows.Count > 0)
                    {
                        directionNumber = Convert.ToInt32(directionsForRecipeTable.Rows[directionsForRecipeTable.Rows.Count - 1]["directionNumber"]);
                        directionNumber++;

                    }

                    else
                    {
                        directionNumber = 1;
                    }


                }

                return directionNumber;
            

           
        }

        public void CreateDirectionsTable()
        {
            directionsTable = RecipeDataSet.Tables.Add("directionsTable");
            
            directionsTable.Columns.Add("directionID", Type.GetType("System.Int32"));
            directionsTable.Columns.Add("recipeID", Type.GetType("System.Int32"));
            directionsTable.Columns.Add("directionNumber", Type.GetType("System.Int32"));
            directionsTable.Columns.Add("direction", Type.GetType("System.String"));
        }

        public void CreateCookInfoTable()
        {
            cookInfoTable = RecipeDataSet.Tables.Add("cookInfoTable");
            cookInfoTable.Columns.Add("cookInfoID", Type.GetType("System.Int32"));
            cookInfoTable.Columns.Add("recipeID", Type.GetType("System.Int32"));
            cookInfoTable.Columns.Add("prepTimeHours", Type.GetType("System.Int32"));
            cookInfoTable.Columns.Add("prepTimeMinutes", Type.GetType("System.Int32"));
            cookInfoTable.Columns.Add("cookTimeHours", Type.GetType("System.Int32"));
            cookInfoTable.Columns.Add("cookTimeMinutes", Type.GetType("System.Int32"));
            cookInfoTable.Columns.Add("ovenTemp", Type.GetType("System.Int32"));
        }
                                    
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
