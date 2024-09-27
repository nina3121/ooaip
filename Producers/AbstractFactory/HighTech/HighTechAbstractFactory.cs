namespace AbstractFactory
{
    internal class HighTechAbstractFactory : IAbstractFactory 
    {
        public IChair CreateChair()
        {
            return new HighTechChair();
        }
        public ISofa CreateSofa()
        {
            return new HighTechSofa();
        }
        public IWardrobe CreateWardrobe()
        {
            return new HighTechWardrobe();
        }
    }
}
