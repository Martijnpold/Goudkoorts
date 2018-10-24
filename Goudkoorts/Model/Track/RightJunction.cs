using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    class RightJunction : JunctionBase
    {
        public override Direction GetNext()
        {
            return Direction.Right;
        }

        public override Direction GetPrevious()
        {
            return Direction;
        }

        public override List<Direction> GetAllConnections()
        {
            Direction[] dirs = { Direction.Up, Direction.Down, Direction.Right };
            return new List<Direction>(dirs);
        }

        public override char GetIcon()
        {
            if (Direction.Equals(Direction.Up))
            {
                return '╝';
            }
            else
            {
                return '╗';
            }
        }
    }
}
