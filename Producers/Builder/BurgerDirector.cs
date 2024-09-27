namespace Builder
{
    class BurgerDirector
    {
        private BuilderBurger _burger;
        public void SetBurger(BuilderBurger burger)
        {
            _burger = burger;
        }
        public void GetCookedBurger()
        {
            _burger.WithCheese();
            _burger.WithSauce();
            _burger.WithMeat();
            _burger.WithTomato();
            _burger.WithSalad();
        }
    }
}
