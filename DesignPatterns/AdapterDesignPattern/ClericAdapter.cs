using System;

namespace AdapterDesignPattern
{
    // This is adapter, that enables simple clerics to use Attack() method, which is reserved only for adventurers.
    public class ClericAdapter : IAdventurer
    {
        // Here adapter stores reference to given cleric.
        private Cleric _cleric = new Cleric();

        // Constructor takes instance of a cleric that wants to use method from IAdventurer interface, and saves it into adapter.
        public ClericAdapter(Cleric cleric)
        {
            _cleric = cleric;
        }

        // Since Adapter implements IAdventurer interface, it has Attack() method.
        // This method calls cleric's heal ability.
        // That way, cleric can use Attack() method even tho he is not an adventurer, and this.
        public void Attack()
        {
            _cleric.Heal();
        }
    }
}
