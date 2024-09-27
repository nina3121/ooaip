namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        IWardrobe CreateWardrobe();
    }
}
