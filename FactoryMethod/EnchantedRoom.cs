using System;

namespace FactoryMethod
{
    public class EnchantedRoom : Room
    {
        private Spell spell;

        public EnchantedRoom(Int32 n, Spell spell) : base(n)
        {
            this.spell = spell;
        }
    }
}
