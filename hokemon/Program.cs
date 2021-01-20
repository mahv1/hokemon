using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Hokeworld home of the hokemon!");

            // Instantiation of new hokemon

            hokemon hoke01 = new hokemon();  // INSTANTIATE new hokemon object referred to as Hoke01

            hoke01.get_details();

            hokemon hoke02 = new hokemon();  // INSTANTIATE Hoke02

            hoke02.get_details();

        }
    }
}
