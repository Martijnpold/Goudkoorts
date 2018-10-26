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
            if (direction == Direction.Up) return Direction.Down;
            if (direction == Direction.Right) return Direction.Left;
            if (direction == Direction.Down) return Direction.Up;
            if (direction == Direction.Left) return Direction.Right;
            return Direction.None;
        }
    }
}