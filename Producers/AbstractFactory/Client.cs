namespace AbstractFactory
{
    class Client
    {
        private IChair _chair;
        private ISofa _sofa;
        private IWardrobe _wardrobe;
        public Client(IAbstractFactory factory)
        {
            _chair = factory.CreateChair();
            _sofa = factory.CreateSofa();
            _wardrobe = factory.CreateWardrobe();
        }
        public void Get()
        {
            _chair.GetChair();
            _sofa.GetSofa();
            _wardrobe.GetWardrobe();
        }
    }
}
