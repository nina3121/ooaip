namespace Builder
{
    class FishBurger : BuilderBurger
    {
        private Burger _burger;
        public override void Reset()
        {
            _burger = new Burger();
        }
        public override void WithCheese() { }
        public override void WithSalad() { }
        public override void WithSauce() { }
        public override void WithTomato() { }
        public override void WithMeat() { }
        public Burger GetBurger()
        {
            Burger burger = _burger;
            this.Reset();
            return burger;
        }
    }
}
