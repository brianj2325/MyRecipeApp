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
        Recipe recipe;
        List<Directions> directions = new List<Directions>();
        List<Label> labels = new List<Label>();
        List<Button> buttons = new List<Button>();

        DataSet RecipeDataSet;
        DataTable directionsTable = new DataTable("directionsTable");
        DataTable cookInfoTable = new DataTable("directionInfoTable");
        DataTable directionsForRecipeTable = new DataTable("directionsForRecipeTable");

        string connectionString = @"Data Source=OfficeComputer\SQLEXPRESS;Initial Catalog=MyRecipeAppDB;Integrated Security=True";
        int directionID;
        int directionNumber = 1;

        int rowControl = 4;
        int columnControl = 100;
        

        public AddDirectionsForm(Recipe recipe, DataSet dataSet)
        {
            InitializeComponent();

            RecipeDataSet = dataSet;
            this.recipe = recipe;
            
            if (this.recipe.directions != null)
            {
                directions = this.recipe.directions;
                DisplayDirections();
            }

            if (!dataSet.Tables.Contains("directionsTable"))
            {

                CreateDirectionsTable(); 
            }
            if (!dataSet.Tables.Contains("cookinfoTable"))
            {
                CreateCookInfoTable();
            }
            lbl_RecipeID.Text = recipe.recipeID.ToString();
            

        }

        private void RenumberDirections()
        {
            List<Directions> tempDirections = new List<Directions>();
            int directionNum = 1;
            foreach(Directions direction in directions)
            {
                tempDirections.Add(direction);
            }

            directions.Clear();

            foreach (Directions direction in tempDirections)
            {
                direction.directionNumber = directionNum;
                directions.Add(direction);
                directionNum++;

            }

            tempDirections.Clear();



        }
        private void DisplayDirections()
        {
            int r = rowControl;
            RenumberDirections();

            foreach (Directions direction in directions)
            {
                
                string directionString = direction.directionNumber.ToString() + ". " + direction.direction;
                
                    CreateLabel(directionString, "lbl_direction" + r.ToString(), r, columnControl);
                    CreateButton("Delete", r, columnControl + 600, direction);
                    
                if (directionString.Length > 200)
                {
                    if (directionString.Length > 400)
                    {
                       
                    }
                    else
                    {
                        r = r + 3;
                    }
                }
                else
                {
                    r = r + 2;
                }
                
            }
          
        }
        public void CreateLabel(string labelText, string labelName, int x, int y)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Name = labelName + x.ToString();
            label.Top = x * 25;
            label.Left = y;
            label.Text = labelText;
            label.AutoSize = true;
            label.MaximumSize = new Size(500, 0);
            labels.Add(label);

        }
        public void ClearLabels()
        {
            foreach (Label label in labels)
            {
                this.Controls.Remove(label);
            }
            foreach (Button button in buttons)
            {
                this.Controls.Remove(button);
            }


        }
        public void CreateButton(string buttonText, int x, int y, Directions direction)
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
                var labelToRemove = this.Controls["lbl_direction"];

                this.Controls.Remove(labelToRemove);
                var buttonToRemove = this.Controls[buttonText + x.ToString()];
                this.Controls.Remove(buttonToRemove);
                directions.Remove(direction);
                ClearLabels();
                DisplayDirections();


            };
            buttons.Add(button);

        }
        private void btn_AddDirection_Click(object sender, EventArgs e)
        {
            Directions direction = new Directions();




            direction.directionNumber = directionNumber;
            direction.direction = txt_Directions.Text;
            directions.Add(direction);
            directionNumber++;

            DisplayDirections();
            txt_Directions.Text = "";
            
        }

        private void btn_Review_Click(object sender, EventArgs e)
        {
            updateCookInfoTable();
            updateDirectionTable(directions);
            recipe.ovenTemp = Convert.ToInt32(cmb_OvenTemp.Text);
            recipe.prepTimeHours = Convert.ToInt32(cmb_PrepHours.Text);
            recipe.prepTimeMinutes = Convert.ToInt32(cmb_PrepMinutes.Text);
            recipe.cookTimeHours = Convert.ToInt32(cmb_CookHours.Text);
            recipe.cookTimeMinutes = Convert.ToInt32(cmb_CookMinutes.Text);
            recipe.directions = directions;

            ViewRecipe view = new ViewRecipe();
            ViewRecipeForm viewRecipeForm = new ViewRecipeForm(recipe, RecipeDataSet);
            //MessageBox.Show(view.PrintRecipe(recipe));

            //RecipeReview reviewRecipe = new RecipeReview(recipeID,RecipeDataSet);
            this.Hide();
            viewRecipeForm.ShowDialog();
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

        
        private void updateDirectionTable(List<Directions> directions)
        {
            RenumberDirections();
            foreach (Directions direction in directions)
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    var sqlQuery = "select * from DirectionTable";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                    dataAdapter.Fill(directionsTable);
                    DataRow row = RecipeDataSet.Tables["directionsTable"].NewRow();
                    directionID = GetTableID(directionsTable, "directionID");

                    row["directionID"] = directionID;
                    row["recipeID"] = recipe.recipeID;
                    row["directionNumber"] = direction.directionNumber;
                    row["direction"] = direction.direction;

                    RecipeDataSet.Tables["directionsTable"].Rows.Add(row);

                    new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(directionsTable);
                    sqlConn.Close();
                }
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

        //private int GetDirectionNumber()
        //{
        //    int directionNumber = 0;
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        sqlConn.Open();
        //        var sqlQuery = "select * from DirectionTable WHERE recipeID=" + lbl_RecipeID.Text;
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

        //        dataAdapter.Fill(directionsTable);

        //    }

        //        if (directionsForRecipeTable != null)
        //        {
        //            if (directionsForRecipeTable.Rows.Count > 0)
        //            {
        //                directionNumber = Convert.ToInt32(directionsForRecipeTable.Rows[directionsForRecipeTable.Rows.Count - 1]["directionNumber"]);
        //                directionNumber++;

        //            }

        //            else
        //            {
        //                directionNumber = 1;
        //            }


        //        }

        //        return directionNumber;
            

           
        //}

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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AddIngredientsForm ingredientsForm = new AddIngredientsForm(recipe, RecipeDataSet);
            this.Hide();
            ingredientsForm.ShowDialog();
            this.Close();
            
        }
    }
}
