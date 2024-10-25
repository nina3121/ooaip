namespace Adapter.Ducks
{
    public class DomesticDuck : IDuck
    {
        public string Crack()
        {
            return "domestic duck is cracking";
        }

        public string Walk()
        {
            return "domestic duck is walking";
        }
    }
}
