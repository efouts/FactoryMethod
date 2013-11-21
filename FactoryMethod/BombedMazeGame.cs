using System;

namespace FactoryMethod
{
    public class BombedMazeGame : MazeGame
    {
        protected override Wall MakeWall()
        {
            return new BombedWall();
        }

        protected override Room MakeRoom(Int32 n)
        {
            return new RoomWithABomb(n);
        }
    }
}
