using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipesApp
{
    public class Recipe
    {
        public int recipeID { get; set; }

        public string recipeName { get; set; }

        public string category { get; set; }

        public string description { get; set; }

        public int ovenTemp { get; set; }

        public int prepTimeMinutes { get; set; }

        public int prepTimeHours { get; set; }

        public int cookTimeMinutes { get; set; }

        public int cookTimeHours { get; set; }

        public List<Ingredient> ingredients { get; set; }

        public List<Directions> directions { get; set; }
    }
}
