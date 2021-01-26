using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class BattleArena
    {
        public void Talk(hokemon Talker)
        {
            Console.WriteLine("Hello my name is {0}", Talker.Name );
        }

        public void startABattle(hokemon object01, hokemon object02)
        {
            Console.WriteLine("{0}: I want a battle", object01.Name);
            Console.WriteLine("{0}: I accept", object02.Name);
            Console.WriteLine("{0}: Says I have an attack of {2}\n I don't care I can defend with {3}!!", object01.Name, object02.Name, object01.attackCalculator(), object02.defenceCalculator()
                );
        }
    }
}
