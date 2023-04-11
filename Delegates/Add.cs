using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentingWithC_
{
    public  class Add
    {

        public static int AddNum(int num,int p)
        {
            int temp = num;
            num += p;
            Console.WriteLine("In AddNum----->Num was {0},was added {1} and became {2}.", temp,p, num);
            return num;
        }
    }
}
