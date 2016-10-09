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

                Recipe_Table recipe = context.Recipe_Tables.FirstOrDefault(r => r.Name == "Chicken Salad");
                //Above line is for searching chicken salad recipe, below line displays
                //it's ID which we know is 1 b/c it's the only recipe in the table
                Console.WriteLine(recipe.Id);



//***********Above is how to select something from your table****

//************Below was how to insert into your table****************
                //Recipe_Table recipe = new Recipe_Table
                //{
                //    Name = "Chicken Salad"
                //};

                //context.Recipe_Tables.Add(recipe);
                //context.SaveChanges(); //Always save changes and refresh
               
                
                //Add a new recipe to our recipe table
                //Like adding new object to our recipes collection
                //context.Recipe_Tables

            //***********************************************************


            }
               
        }
    }
}
