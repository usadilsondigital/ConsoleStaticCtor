namespace ConsoleStaticCtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The creation of this instance activates the static constructor.
            Bus bus1 = new Bus(71);

            // Create a second bus.
            Bus bus2 = new Bus(72);


            // Send bus1 on its way.
            bus1.Drive();



        }
    }
}
