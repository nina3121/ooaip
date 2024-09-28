namespace Singleton
{
    public class HighTechAbstractFactory : IAbstractFactory
    {
        private HighTechAbstractFactory() { }
        private static HighTechAbstractFactory _instance;
        public static HighTechAbstractFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HighTechAbstractFactory();
                }
                return _instance;
            }
        }
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
