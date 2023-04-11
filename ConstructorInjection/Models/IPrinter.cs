using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection.Models
{
    public  interface IPrinter
    {
        static int Counter { get; set; }
        void Print();
    }
}
