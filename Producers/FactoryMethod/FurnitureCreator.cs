namespace FactoryMethod
{
    public abstract class FurnitureCreator
    {
        protected abstract ISofa CreateSofa();
        protected abstract IChair CreateChair();
        protected abstract IWardrobe CreateWardrobe();
        public string CreateSofaFurniture() 
        {
            Console.WriteLine("Делаем диван");
            var sofa = CreateSofa();
            return sofa.Print();
        }
        public string CreateChairFurniture()
        {
            Console.WriteLine("Делаем стул");
            var chair = CreateChair();
            return chair.Print();
        }
        public string CreateWardrobeFurniture() 
        {
            Console.WriteLine("Делаем шкаф");
            var wardrobe = CreateWardrobe();
            return wardrobe.Print();
        }
    }
}
