using System;

namespace FactoryMethod
{
    public class MazeGame
    {
        public Maze CreateMaze() 
        {
            var aMaze = MakeMaze();

            var someRoom = MakeRoom(1);
            var anotherRoom = MakeRoom(2);
            var theDoor = MakeDoor(someRoom, anotherRoom);

            aMaze.AddRoom(someRoom);
            aMaze.AddRoom(anotherRoom);

            someRoom.SetSide(Room.Side.North, MakeWall());
            someRoom.SetSide(Room.Side.East, theDoor);
            someRoom.SetSide(Room.Side.South, MakeWall());
            someRoom.SetSide(Room.Side.North, MakeWall());

            anotherRoom.SetSide(Room.Side.North, MakeWall());
            anotherRoom.SetSide(Room.Side.East, MakeWall());
            anotherRoom.SetSide(Room.Side.South, MakeWall());
            anotherRoom.SetSide(Room.Side.North, theDoor);

            return aMaze;
        }

        protected virtual Maze MakeMaze()
        {
            return new Maze();
        }

        protected virtual Room MakeRoom(Int32 n)
        {
            return new Room(n);
        }

        protected virtual Wall MakeWall()
        {
            return new Wall();
        }

        protected virtual Door MakeDoor(Room a, Room b)
        {
            return new Door(a, b);
        }
    }
}
