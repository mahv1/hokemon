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

            BattleArena myBattle = new BattleArena(); // INSTANTIATING the myBattle OBJECT from the BattleArena class

            myBattle.Talk(hoke01); // Passing the OBJECT hoke01 and all the attributes into 
            myBattle.startABattle(hoke01, hoke02);
            /*
            hokemon hoke02 = new hokemon();  // INSTANTIATE Hoke02

            hoke02.get_details();
            */
        }
    }
}
