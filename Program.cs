// See https://aka.ms/new-console-template for more information
using AbstractFactory.Contracts;
using AbstractFactory.Implementations;

Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter the Os Type (Mac/Win)");
var osType = Console.ReadLine();

GUIInterface factory;
if(osType == "Mac")
{
     factory = new MacClass();
    Application app = new Application(factory);
    app.CreateUI();
    app.Paint();

}
else if (osType == "Win")
{
    factory = new WindowClass();
    Application app = new Application(factory);
    app.CreateUI();
    app.Paint();
}


