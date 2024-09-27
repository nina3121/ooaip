namespace Builder
{
    internal class CheeseBurger : BuilderBurger
    {
        private Burger _burger;
        public override void Reset()
        {
            _burger = new Burger();
        }
        public override void WithCheese() { }
        public override void WithMeat() { }
        public override void WithSauce() { }
        public override void WithSalad() { }
        public Burger GetBurger()
        {
            Burger burger = _burger;
            this.Reset();
            return burger;
        }
    }
}
