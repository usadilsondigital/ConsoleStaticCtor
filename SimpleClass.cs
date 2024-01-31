using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStaticCtor
{
    internal class SimpleClass
    {
        //Static variable that must be initialized at run time.
        static readonly long baseline;

        //Static ctor is called at most time, before any
        //instance ctor is invoked or member is accessed.
        static SimpleClass()
        {
            baseline = DateTime.Now.Ticks;
        }
    }
}
