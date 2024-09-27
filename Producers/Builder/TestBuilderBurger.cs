namespace Builder
{
    internal class TestBuilderBurger
    {
        public void TestBurger(BuilderBurger burger)
        {
            var cookedBurger = burger.GetBurger();
            List<string> ingredientsFirstBurger = cookedBurger.GetIngredients();

    }
}
