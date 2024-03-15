using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    internal class EuropTime:Time
    {
        //public EuropTime() { }
        public override StringBuilder DateTimeWrite()
        {
            var st = new StringBuilder("");
            st.AppendLine(DateTime.Now.ToString("Current date and time in Europ style: " + DateTime.Now));
            Console.WriteLine("Current date and time in Europ style: " + DateTime.Now);
            return st;
        }
    }
}
