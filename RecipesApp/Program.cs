using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (RecipesEntities context = new RecipesEntities())
            {

                Recipe_Table recipe = new Recipe_Table
                {
                    Name = "Chicken Salad"
                };

                context.Recipe_Tables.Add(recipe);
                context.SaveChanges(); //Always save changes and refresh
               
                
                //Add a new recipe to our recipe table
                //Like adding new object to our recipes collection
                //context.Recipe_Tables
            }
               
        }
    }
}
