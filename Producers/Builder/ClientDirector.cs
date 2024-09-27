namespace Builder
{
    internal class ClientDirector
    {
        List<string> ListIngredients = new List<string> { "Сыр", "Мясо",
            "Помидор", "Соус", "Листья салата"};
        List<string> ClientBurger = new List<string>();
        public void BuildClientBurger(BuilderBurger burger)
        {
            foreach (var ingredient in ListIngredients)
            {
                Console.WriteLine($"Хотите ли вы добавить в бургер {ingredient}? (да/нет)");
                string Answer = Console.ReadLine().ToLower().Trim();
                if (Answer == "да")
                {
                    switch (ingredient)
                    {
                        case "Сыр":
                            {
                                burger.WithCheese();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Мясо":
                            {
                                burger.WithMeat();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Помидор":
                            {
                                burger.WithTomato();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Соус":
                            {
                                burger.WithSauce();
                                ClientBurger.Add(ingredient);
                                break;
                            }
                        case "Листья салата":
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
