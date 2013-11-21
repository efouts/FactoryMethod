using System;

namespace FactoryMethod
{
    public abstract class EnchantedMazeGame : MazeGame
    {
        protected override Room MakeRoom(Int32 n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        protected override Door MakeDoor(Room a, Room b)
        {
            return new DoorNeedingSpell(a, b);
        }

        protected abstract Spell CastSpell();
    }
}
