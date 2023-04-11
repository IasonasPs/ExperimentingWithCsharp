using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using ReflectionAtLast;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("This is the type of an instance of the class Car :"+car.GetType().FullName); //TypeOf Instance
            Console.WriteLine("This is the type of the 'Class' as a type: "+typeof(Car).FullName);          //TypeOf Type





            Console.ReadKey();
        }
    }
}