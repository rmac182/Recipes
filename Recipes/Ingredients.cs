using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    public class Ingredient
    {

        
        public string IngName { get; set; }
        public string Amount { get; set; }


        public override string ToString()
        {
            return $"{Amount} - {IngName}";
        }


    }
}
