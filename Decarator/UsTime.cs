using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    internal class UsTime: Time
    {
        public override StringBuilder DateTimeWrite()
        {
            //norm code
            //    DateTime currentTime = DateTime.Now;
            //Console.WriteLine("Current date and time in American style: " + currentTime.ToString("MM/dd/yyyy hh:mm:ss tt"));
            StringBuilder sb = new StringBuilder();
            DateTime currentTime = DateTime.Now;
            sb.AppendLine("Current date and time in American style: " + currentTime.ToString("MM/dd/yyyy hh:mm:ss tt"));
            Console.WriteLine("Current date and time in American style: " + currentTime.ToString("MM/dd/yyyy hh:mm:ss tt"));
            return sb;
        }
}
}
