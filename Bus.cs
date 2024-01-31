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

        //Static ctor to initializate the static variable
        //its invoked before the first instance ctor is run
        static Bus()
        {
            globalStartTime = DateTime.Now;

            //The following statement produces the first line of output
            //and the line occurs only once.
            Console.WriteLine("Static ctor sets global start time to {0}",
                globalStartTime.ToLongTimeString());

        }

        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            Console.WriteLine("Bus #{0} is created.", RouteNumber);
        }


    }
}
