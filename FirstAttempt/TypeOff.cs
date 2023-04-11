using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FirstAttempt
{
    public  class TypeOff<T>
    {
        private static Type type = typeof(T) ;

        public static void PrintTypeinfo()
        {
            Console.WriteLine("Class : " + type.Name);
            Console.WriteLine("NameSpace : " + type.Namespace);
            Console.WriteLine("Assemply : " + type.Assembly.GetName().Name);
            Console.WriteLine("Assemply : " + type.Assembly.FullName);
        }

        public static void Getmembers()
        {
            Console.WriteLine("<=====================>");
            var test2 = type.GetMembers().ToList();

            foreach (var item in test2)
            { Console.WriteLine(item.Name); }
        }

        public static void GetProperties()
        {
            var test = type.GetProperties().ToList();
            Console.WriteLine("<=====================>");
            Console.WriteLine("Properties of {0} :", type.Name);
            foreach (var item in test)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void ReturnNumberProperties()
        {
            PropertyInfo[] propertyInfos = type.GetProperties();
            Console.WriteLine("Number of Properties of {0} Class ---> {1} ",type.Name,propertyInfos.Count());
           
        }

        public static void Constructors() 
        {
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo.DeclaringType.Name);
                Console.WriteLine("! ! !! ! !! ! !! ! !! ! !");
            }
        }




    }
}
