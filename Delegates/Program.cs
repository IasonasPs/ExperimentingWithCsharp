using System;



public delegate int NumberChanger(int n,int p);

namespace ExperimentingWithC_
{
    public class TestDelegate : Square
    {
        static int num = 0;

        

        public static int getNum(int result)
        {
            Console.WriteLine(result);
            return result;
        }

        public static int InvokeDelegate(NumberChanger test,int parameter1,int parameter2)
        {
           int x = test(parameter1,parameter2);
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Add add = new Add();
            

            Console.WriteLine("- - - - - - - - - - - - - - ");
            NumberChanger nc1 = new NumberChanger(Add.AddNum);
            NumberChanger nc2 = new NumberChanger(SquareNum);
            nc1 += nc2;

            int output =  InvokeDelegate(nc1, 10,2);
            //InvokeDelegate(nc1, 10, 2);
            getNum(output);           
        }
    }
}