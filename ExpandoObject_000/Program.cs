using System.Dynamic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace ExpandoObject_000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dynamic type
            dynamic user = new ExpandoObject();
            user.name = "John";

            dynamic d2 = 123;
            Console.WriteLine(d2.GetType());
            user.d2 = d2;
            Console.WriteLine(user.d2);
            d2 = "Hello";
            Console.WriteLine(d2.GetType());
            user.d2 = d2;
            Console.WriteLine(user.d2);
             
            user.Print = (Func<string>)
                (
                    () => { return user.name; }
                );
            Console.WriteLine(user.Print());
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            foreach(KeyValuePair<string, object> kvp in user)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            KeyValuePair<string, object> test0 = new KeyValuePair<string, object>("name", "John");
            Console.WriteLine(test0.Value);
            Console.WriteLine("- - - - - - - - - - - - - - - ");



        }
    }
}