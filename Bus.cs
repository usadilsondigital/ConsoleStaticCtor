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
        public static DateTime globalStartTime { get; set; }


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

        public void Drive() {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;

        // For demonstration purposes we treat milliseconds as minutes to simulate
        // actual bus times. Do not do this in your actual bus schedule program!
        Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.",
                                this.RouteNumber,
                                elapsedTime.Milliseconds,
                                globalStartTime.ToShortTimeString());
        }
        


    }
}
