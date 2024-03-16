using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    internal class SymbolUsTime:Deco
    {
        protected Time t;
        public SymbolUsTime(Time time)
        {
            t = time;
        }
        public override void printSymbol()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("(o･ω･o)");
        }
        public override StringBuilder DateTimeWrite()
        {
            //norm code
            //t.DateTimeWrite();
            //printSymbol();
            StringBuilder sb = t.DateTimeWrite(); 
            sb.AppendLine(); 
            printSymbol(); 
            return sb;
        }

    }
}
