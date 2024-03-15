using Decarator;
using static System.Net.Mime.MediaTypeNames;

namespace Decatator
{
    class Program
    {
        static void Main(string[] args)
        {

            Time time = new EuropTime();
            //time = new SymbolEuropTime(time);
            //time.DateTimeWrite();
            //time = new EuropTime();
            //time = new AnouthersymbolEuropTime(time);
            //time = new AnouthersymbolEuropTime(time);
            //time = new AnouthersymbolEuropTime(time);
            //time.DateTimeWrite();

            //Time time = new UsTime();
            time = new SymbolUsTime(time);
            time.DateTimeWrite();
            time = new UsTime();
            time = new AnouthersymbolUsTime(time);
            time = new AnouthersymbolUsTime(time);
            time.DateTimeWrite();
            time = new AnouthersymbolUsTime(time);
            time.DateTimeWrite();
        }
    }
}