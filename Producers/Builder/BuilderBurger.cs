namespace Builder
{
    abstract class BuilderBurger
    {
        protected Burger _burger;
        public virtual void Reset()
        {
            _burger = new Burger();
        }
        public virtual void WithCheese() { }
        public virtual void WithMeat() { }
        public virtual void WithTomato() { }
        public virtual void WithSauce() { }
        public virtual void WithSalad() { }
        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
