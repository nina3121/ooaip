namespace TemplateMethod
{
    public abstract class BuildDrink
    {
        public void Cook()
        {
            BoilTheWater();
            Ingredient();
            IsSugar();
            AddSugar();
            Adds();
        }

        private void BoilTheWater()
        {
            Console.WriteLine("кипятим воду для напитка");
        }

        protected abstract void Ingredient();

        protected abstract void IsSugar();

        private void AddSugar()
        {
            Console.WriteLine("добавляем сахар");
        }

        protected abstract void Adds();
    }
}
