using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Room
    {
        public enum Side { North, East, South, West }

        public Room(Int32 n)
        { }

        public void SetSide(Side side, ICanBeTheSideOfARoom @object)
        { }
    }
}
