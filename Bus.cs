using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStaticCtor
{
    public class Bus
    {
        //Static variable  used by all Bus Instances.
        //Represent the time the first bus of the day starts its route.
        public static readonly DateTime globalStartTime { get; set; }


        //Property for the number of each bus.
        protected int RouteNumber { get; set; }

    }
}
