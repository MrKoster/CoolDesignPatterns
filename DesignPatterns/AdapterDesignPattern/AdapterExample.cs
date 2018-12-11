using DesignPatternsCommon;
using System;

namespace AdapterDesignPattern
{
    // Addapter design pattern helps when client needs to call a method, but it's interface is incompatible.
    // Example below demonstrates how client (in example - cleric) can use method form IAdventurer interface,
    // even tho it doesn't accualy implement this interface.
    // All becaouse of adapter clericAdapter.

    public class AdapterExample : IExample
    {
        public void RunExample()
        {
            // Adventurer Merlin and Cleric Alfred enter the dungeon.
            IAdventurer magusMerlin = new Magus();
            Cleric clericAlfred = new Cleric();

            // Suddenly scary dragon appears! Adventurer Merlin attacks the dragon! 
            // But dragon also attacks and hurts Adventurer Merlin badly!
            magusMerlin.Attack();

            // Unfortunatelly, our Cleric Alfred is not an adventurer at all! He can't attack!
            // No worries, Adapter comes to rescue! It ADAPTS (hehe) our Cleric Alfred to IAdventurer!
            IAdventurer clericAdapter = new ClericAdapter(clericAlfred);

            // Now our Cleric can use his Heal ability thru mentioned Adapter, because that way it's considered an IAdventurer attack!
            clericAdapter.Attack();

            // Hurray! Battle is won! Adapter saved our heroes!
            Console.ReadLine();
        }
    }
}
