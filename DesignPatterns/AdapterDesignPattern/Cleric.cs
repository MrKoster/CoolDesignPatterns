using System;

namespace AdapterDesignPattern
{
    // Clerics can heal people using thier heal ability.
    // Clerics are NOT adventurers tho.
    public class Cleric
    {
        // Heal ability of cleric
        public void Heal()
        {
            Console.WriteLine("Ultimate Healing!");
        }
    }
}
