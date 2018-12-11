using System;

namespace AdapterDesignPattern
{
    // This is our adventurer interface. It Says that every adventurer must know how to attack.
    public interface IAdventurer
    {
        void Attack();
    }
}
