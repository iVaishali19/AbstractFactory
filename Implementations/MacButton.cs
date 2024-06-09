using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class MacButton : IButtonInterface
    {
        public void Paint()
        {
            Console.WriteLine("Mac button");
        }
    }
}