namespace AbstractFactory
{
    internal class LoftAbstractFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new LoftChair();
        }
        public ISofa CreateSofa()
        {
            return new LoftSofa();
        }
        public IWardrobe CreateWardrobe()
        {
            return new LoftWardrobe();
        }
    }
}
