using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class TestBuilderBurger
    {
        public void TestBurger(BurgerBuilder burger)
        {
            var cookedBurger = burger.GetBurger();
            List<string> ingredientsFirstBurger = cookedBurger.GetIngredients();

            ClientDirector client = new ClientDirector();
            client.BuildClientBurger(burger);
            List<string> ingredientsSecondBurger = client.GetClientBurger();

            bool IsCorrectBurger = ingredientsFirstBurger.Count == ingredientsSecondBurger.Count;
            if (IsCorrectBurger)
            {
                foreach (var ingredient1 in ingredientsFirstBurger)
                {
                    if (!ingredientsSecondBurger.Contains(ingredient1))
                    {
                        IsCorrectBurger = false;
                        break;
                    }
                }
            }
            if (IsCorrectBurger)
            {
                Console.WriteLine("The burger is cooked correctly");
            }
            else
            {
                Console.WriteLine("The burger is cooked incorrectly");
            }
        }
    }
}
