using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ClientDirector
    {
        List<string> ListIngredients = new List<string> { "Cheese", "Meat",
            "Tomato", "Sauce", "Salad"};
        List<string> ClientBurger = new List<string>();
        public void BuildClientBurger(BurgerBuilder burger)
        {
            foreach (var ingredient in ListIngredients)
            {
                Console.WriteLine($"Do you want to add {ingredient} to the burger? (yes/no)");
                string Answer = Console.ReadLine().ToLower().Trim();
                if (Answer == "yes")
                {
                    switch (ingredient)
                    {
                        case "Cheese":
                            {
                                burger.WithCheese();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Meat":
                            {
                                burger.WithMeat();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Tomato":
                            {
                                burger.WithTomato();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Sauce":
                            {
                                burger.WithSauce();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Salad":
                            {
                                burger.WithSalad();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                    }
                }
            }
        }
        public List<string> GetClientBurger()
        {
            return ClientBurger;
        }
    }
}
