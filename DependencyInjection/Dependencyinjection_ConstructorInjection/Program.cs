using ConstructorInjection.Models;

namespace ConstructorInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ConstructorInjection ci = new ConstructorInjection(new Printer());
            ci.Print();

            Printer printer = new Printer();
            printer.Print("thats from inside Program!!");
            Console.ReadLine();
        }
    }
}