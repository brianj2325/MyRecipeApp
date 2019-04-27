using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipesApp
{
    class ViewRecipe
    {
        string connectionString = @"Data Source=OfficeComputer\SQLEXPRESS;Initial Catalog=MyRecipeAppDB;Integrated Security=True;";
        int recipeID;

        private List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            Ingredient ingredient = new Ingredient();

           


            return ingredients;
        }

        public string PrintRecipe(Recipe recipe)
        {
            StringBuilder printedRecipe = new StringBuilder();

            printedRecipe.Append("------------------------------------------------------------------\n");
            printedRecipe.Append($"ID: {recipe.recipeID.ToString()}\n");
            printedRecipe.Append($"Recipe Name: {recipe.recipeName}\n");
            printedRecipe.Append($"Category {recipe.category}\n");
            printedRecipe.Append($"Description: {recipe.description}\n");
            printedRecipe.Append("------------------------------------------------------------------\n");
            printedRecipe.Append($"Prep Time: {recipe.prepTimeHours} Hours and {recipe.prepTimeMinutes} Minutes \n");
            printedRecipe.Append($"Cook Time: {recipe.cookTimeHours} Hours and {recipe.cookTimeMinutes} Minutes \n");
            printedRecipe.Append($"Oven Temp: {recipe.ovenTemp}\n");
            printedRecipe.Append($"Ingredients: \n");
            foreach (var ingredient in recipe.ingredients)
            {
                printedRecipe.Append($"{ingredient.amount} {ingredient.units} {ingredient.ingredientName}\n");
            }
            printedRecipe.Append($"Directions: ");
            foreach (var direction in recipe.directions)
            {
                printedRecipe.Append($"{direction.directionNumber}. {direction.direction}\n");
            }
            
            
            printedRecipe.Append("------------------------------------------------------------------\n");

            return printedRecipe.ToString();
        }
        

    }

    
}
