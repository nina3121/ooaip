namespace AbstractFactory
{
    internal class ModernAbstractFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public IWardrobe CreateWardrobe()
        {
            return new ModernWardrobe();
        }
    }
}
