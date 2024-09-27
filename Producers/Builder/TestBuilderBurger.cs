namespace Builder
{
    internal class TestBuilderBurger
    {
        public void TestBurger(BuilderBurger burger)
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
                Console.WriteLine("Бургер приготовлен правильно");
            }
            else
            {
                Console.WriteLine("Бургер приготовлен неверно");
            }
        }
    }
}
