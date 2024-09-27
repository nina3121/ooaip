namespace Builder
{
    public class ClientDirector
    {
        private List<string> ListIngredients = new List<string> { "Cheese", "Meat",
            "Tomato", "Sauce", "Salad", "Fish"};
        private List<string> ClientBurger = new List<string>();
        public void BuildClientBurger(BuilderBurger burger) 
        {
            foreach (var ingredient in ListIngredients)
            {
                Console.WriteLine($"would you like to add {ingredient} to the burger? (yes/no)");
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
                        case "Fish":
                            {
                                burger.WithFish();
                                ClientBurger.Add(ingredient); 
                                break;
                            }
                    }
                }
            }
        }
        public List<string> GetIngredients() 
        {
            return ClientBurger;
        }
    }
}
