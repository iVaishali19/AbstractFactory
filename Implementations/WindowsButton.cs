using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    internal class WindowsButton : IButtonInterface
    {
        public void Paint()
        {
            Console.WriteLine("Windows button");
        }
    }
}