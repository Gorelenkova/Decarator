using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    class SymbolEuropTime:Deco
    {
        protected Time t;
        public SymbolEuropTime(Time time) 
        {
            t = time;   
        }
        public override void  printSymbol()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("0*0");
            //base.DateTimeWrite();

        }
        public override StringBuilder DateTimeWrite()
        {
            //норм код просто закоментила для пробы
            //t.DateTimeWrite();
            //printSymbol();

            StringBuilder sb = t.DateTimeWrite(); // Получаем строку от времени t
            sb.AppendLine(); // Добавляем пустую строку перед символами
            printSymbol(); // Добавляем символы
            return sb;
        }
        

    }
}
