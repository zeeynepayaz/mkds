using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mkds.Models
{
    public class Recipe
    {
        public string name;
        public string instruction;
        public Recipe_Ingredient recipe_ingredient;
        public Chef chef;
    }
}