namespace ExperimentingWithC_
{
    public class Square
    {
        public static int SquareNum(int p, int num)
        {
            int temp = num;
            num *= num;
            Console.WriteLine("In SquareNum----->Num was {0},and became {1}.", temp, num);

            return num;

        }
    }
}