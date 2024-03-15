using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    internal class AnouthersymbolUsTime:Deco
    {
        protected Time t;
        public AnouthersymbolUsTime(Time time)
        {
            t = time;
        }
        public override void printSymbol()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(";)");
        }
        public override StringBuilder DateTimeWrite()
        {
            StringBuilder sb = t.DateTimeWrite(); // Получаем строку от времени t
            sb.AppendLine(); // Добавляем пустую строку перед символами
            printSymbol(); // Добавляем символы
            return sb;
        }
    }
}
