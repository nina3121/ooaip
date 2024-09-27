namespace Builder
{
    public class Burger
    {
        private readonly List<string> ingredients;
        public Burger()
        {
            ingredients = new List<string>();
        }
        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }
        public List<string> GetIngredients()
        {
            return ingredients;
        }
    }
}
