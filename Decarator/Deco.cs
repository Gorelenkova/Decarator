using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    abstract class Deco:Time
    {
        protected Time time;
        //public Deco(Time t)
        //{
        //    time = t;
        //}
        public abstract void printSymbol();
        //public void SetComponent(Time component)
        //{
        //    time = component;
        //}
        //public virtual void DateTimeWrite()
        //{
        //    if (time != null)
        //    {
        //        time.DateTimeWrite();
        //    }
        //}
    }
}
