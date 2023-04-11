using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection.Models
{
    public class Printer : IPrinter
    {
        public static int Counter=0 ;
        public void Print()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("I am a printer......");
            Console.WriteLine("I have been called {0} times", Counter);
            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
            Counter++;
        }
        public void Print(string message)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("I am a printer......and....{0}",message);
            Console.WriteLine("I have been called {0} times", Counter);
            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - ");
            Counter++;
        }
    }
    

    
}
