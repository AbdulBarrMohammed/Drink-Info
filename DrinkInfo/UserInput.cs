using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkInfo
{
    public class UserInput
    {
        DrinkService drinkService = new();


        internal void GetCategoriesInput()
        {
            drinkService.GetCategories();
        }

    }
}
