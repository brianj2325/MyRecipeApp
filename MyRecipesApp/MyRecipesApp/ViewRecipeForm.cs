using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MyRecipesApp
{
    public partial class ViewRecipeForm : Form
    {
        int x = 5;
        int increaseX;
        int ingredientControl, directionControl;
        List<Ingredient> ingredients = new List<Ingredient>();
        List<Directions> directions = new List<Directions>();
        Recipe recipe = new Recipe();


        //Create list for testing
        //public List<Ingredient> CreateIngredientList()
        //{

        //    for (int i = 0; i < 8; i++)
        //    {
        //        Ingredient ingredient = new Ingredient()
        //        {
        //            ingredientName = "Ingredient " + i,
        //            amount = i.ToString(),
        //            units = "cups"

        //        };
        //        ingredients.Add(ingredient);



        //    }
        //    return ingredients;
        //}


        //Create list for testing
        //public List<Directions> CreateDirectionsList()
        //{

        //    for (int i = 0; i < 8; i++)
        //    {
        //        Directions direction = new Directions()
        //        {
        //            directionNumber = i,
        //            direction = "this is direction" + i

        //        };
        //        directions.Add(direction);



        //    }
        //    return directions;
        //}


        public ViewRecipeForm(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;

        //    recipe.recipeID = 1;
        //        recipe.recipeName = "Sugar Cookies";
        //    recipe.category = "Dinner";
        //    recipe.description = "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        //"12345678901234567890123456789012345678901234567890123456789012345678901234567890";
        //        recipe.ovenTemp = 365;
        //    recipe.prepTimeHours = 1;
        //    recipe.prepTimeMinutes = 20;
        //    recipe.cookTimeHours = 2;
        //    recipe.cookTimeMinutes = 5;
        //    recipe.ingredients = CreateIngredientList();
        //    recipe.directions = CreateDirectionsList();
                
        

            displayRecipeInfo("Recipe Name: ", recipe.recipeName, 1, 100);
            displayRecipeInfo("Recipe ID: ", recipe.recipeID.ToString(), 2, 100);
            displayRecipeInfo("Category: ", recipe.category,3,100);
            displayRecipeInfo("Description: ", recipe.description,4,100);
            displayRecipeInfo("Prep Time: ", displayPrepTime(),1,400);
            displayRecipeInfo("Cook Time: ", displayCookTime(),2,400);
            displayRecipeInfo("Oven Temp: ", recipe.ovenTemp.ToString(),3,400);
            if(recipe.description.Length > 82)
            {
                increaseX = recipe.description.Length / 82;
                x = x + increaseX;
            }
            
            
            CreateLabel("----------------------------------------------------------------------------------------------------" +
                "----------------------------------------------------------------", x, 100);
            x++;
            CreateLabel("Ingredients: ", x, 100);
            CreateLabel("Directions: ", x, 350);
            x++;
            ingredientControl = directionControl = x;




            //CreateLabel("Recipe Name: ", leftControl, 100);
            //CreateLabel(recipe.recipeName, leftControl, 100);
            //CreateLabel("Recipe ID: ", recipe.recipeID.ToString(), leftControl, 100);
            //CreateLabel("Recipe Category: ", recipe.category, leftControl, 100);
            //CreateLabel("Recipe Description: ", recipe.description, leftControl, 100);


            foreach (Ingredient ingredient in recipe.ingredients)
            {
                StringBuilder printIngredient = new StringBuilder();
                printIngredient.Append($"{ingredient.amount}" + " ");
                printIngredient.Append($"{ingredient.units}" + " ");
                printIngredient.Append($"{ingredient.ingredientName}" + " ");

                displayList(printIngredient.ToString(), ingredientControl, 150);
                ingredientControl++;
            }
            foreach (Directions direction in recipe.directions)
            {
                StringBuilder printDirection = new StringBuilder();
                printDirection.Append($"{direction.directionNumber.ToString()}" + ". ");
                printDirection.Append($"{direction.direction}");
                

                displayList(printDirection.ToString(), directionControl, 400);
                directionControl++;
            }
        }

        public string displayCookTime()
        {
            StringBuilder stringCookTime = new StringBuilder();
            stringCookTime.Append($"{recipe.cookTimeHours}" + " Hours ");
            stringCookTime.Append($"{recipe.cookTimeMinutes}" + " Minutes");

            return stringCookTime.ToString();
        }
        public string displayPrepTime()
        {
            StringBuilder stringPrepTime = new StringBuilder();
            stringPrepTime.Append($"{recipe.prepTimeHours}" + " Hours ");
            stringPrepTime.Append($"{recipe.prepTimeMinutes}" + " Minutes");

            return stringPrepTime.ToString();
        }
        public void displayRecipeInfo(string recipeInfo, string recipeData, int x, int y)
        {
            
            CreateLabel(recipeInfo, x, y);
            CreateLabel(recipeData, x, y + 100);
            
        }
        
        public void displayList(string listItem, int x, int y)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Top = x * 25;
            label.Left = y;
            label.Text = listItem;
            label.AutoSize = true;
            

            
        }
        public void CreateLabel(string labelText, int x, int y)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Top = x * 25;
            label.Left = y;
            label.Text = labelText;
            label.AutoSize = true;
            label.MaximumSize = new Size(500, 0);

        }

        private void btn_ExportToFile_Click(object sender, EventArgs e)
        {
            string xml = GetXMLFromObject(recipe);
            //string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //File.WriteAllText(Path.Combine(docpath, "recipe.xml"), xml);

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        public static string GetXMLFromObject(object o)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            catch (Exception ex)
            {
                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }






    }
}
