using ConstructorInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection
{
    internal class ConstructorInjection
    {
        private IPrinter _printer;

        public ConstructorInjection(Printer p)
        {
         this._printer = p;
        }
        public void Print() 
        {
        _printer.Print();
        _printer.Print();
        _printer.Print();
        _printer.Print();
        _printer.Print();
        _printer.Print();
        }
    }
}
