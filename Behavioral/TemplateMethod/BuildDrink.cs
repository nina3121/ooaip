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

        protected void IsSugar()
        {
            Console.WriteLine("хотите ли вы добавить сахар в напиток? (да - 0, нет - 1)");
            int isSugar = Convert.ToInt32(Console.ReadLine());
            if (isSugar == 0)
            {
                Console.WriteLine("сахар добавлен");
            }
            else
            {
                Console.WriteLine("напиток без сахара");
            }
        }

        private void AddSugar()
        {
            Console.WriteLine("добавляем сахар");
        }

        protected abstract void Adds();
    }
}
