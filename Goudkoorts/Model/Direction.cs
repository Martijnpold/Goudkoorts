using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public enum Direction
    {
        Up,
        Right,
        Down,
        Left,
        None
    }

    static class DirectionUtils
    {
        public static Direction GetOpposite(Direction direction)
        {
            if (direction.Equals(Direction.Up)) return Direction.Down;
            if (direction.Equals(Direction.Right)) return Direction.Left;
            if (direction.Equals(Direction.Down)) return Direction.Up;
            if (direction.Equals(Direction.Left)) return Direction.Right;
            return Direction.None;
        }
    }
}