namespace ConsoleStaticCtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The creation of this instance activates the static constructor.
            Bus bus1 = new Bus(71);
        }
    }
}
