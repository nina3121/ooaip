namespace Builder
{
    public class TestBuilderBurger : IBurgerBuilder
    {
        private readonly List<string> _ingredients;
        public TestBuilderBurger() 
        {
            _ingredients = new List<string>();
        }
        public void WithCheese()
        {
            _ingredients.Add("Cheese");
        }
        public void WithMeat()
        {
            _ingredients.Add("Meat");
        }
        public void WithTomato()
        {
            _ingredients.Add("Tomato");
        }
        public void WithSauce()
        {
            _ingredients.Add("Sauce");
        }
        public void WithSalad()
        {
            _ingredients.Add("Salad");
        }
        public void WithFish()
        {
            _ingredients.Add("Fish");
        }
        public bool Build()
        {
            return _ingredients.Contains("Tomato");
        }
    }
}