namespace FactoryMethod
{
    public abstract class FurnitureCreator
    {
        protected virtual ISofa CreateSofa() { return null; }
        protected virtual IChair CreateChair() { return null;  }
        protected virtual IWardrobe CreateWardrobe() { return null; }
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
