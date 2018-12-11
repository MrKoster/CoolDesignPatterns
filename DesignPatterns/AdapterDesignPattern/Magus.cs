using System;

namespace AdapterDesignPattern
{
    // Powerful magus class. Can throw fireballs on enemies.
    // Magi are adventurers (hence IAdventurer interface).
    public class Magus : IAdventurer
    {
        public void Attack()
        {
            Console.WriteLine("Fireball!");
        }
    }
}
