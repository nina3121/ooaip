namespace Builder
{
    class VegetarianBurger : BuilderBurger
    {
        private Burger _burger;
        public void Reset()
        {
            _burger = new Burger();
        }
        public override void WithCheese() { }
        public override void WithSalad() { }
        public override void WithSauce() { }
        public override void WithTomato() { }
        public Burger GetBurger()
        {
            Burger burger = _burger;
            this.Reset();
            return burger;
        }
    }
}
