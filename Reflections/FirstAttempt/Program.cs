using iasonas;
using System.Reflection;

namespace FirstAttempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-");
            Customer customer = new Customer();
            TypeOff<Product> type = new TypeOff<Product>(); 
            
            TypeOff<Product>.ReturnNumberProperties();

            TypeOff<Product>.GetProperties();
            



            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-");

            //--------------------------------
            //Console.WriteLine("_-_-_-_-_-_-_-_-_-_-");
           






            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-");

        }
    }
}