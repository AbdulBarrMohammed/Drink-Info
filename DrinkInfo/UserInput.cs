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

            Console.WriteLine("Choose category:");

            string category = Console.ReadLine();

            while(!Validator.IsStringValid(category))
            {
                Console.WriteLine("\nInvalid category");
                category = Console.ReadLine();
            }

            GetDrinksInput(category);
        }

        private void GetDrinksInput(string category)
        {
            drinkService.GetDrinksByCategory(category);
        }
    }
}
