using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drinks_info
{
    public class UserInput
    {
        DrinksService drinksService = new();

        internal void GetCategoriesInput() {
            drinksService.GetCategories();

            Console.WriteLine("Choose Category");

            string category = Console.ReadLine();

            while(!Validator.IsStringValid(category)){
                System.Console.WriteLine("\nInvalid Category");
                category = Console.ReadLine();

            }
        }


    }
}