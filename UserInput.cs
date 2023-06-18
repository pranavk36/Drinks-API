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
        }


    }
}