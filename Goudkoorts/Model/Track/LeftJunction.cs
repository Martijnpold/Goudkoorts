using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    class LeftJunction : JunctionBase
    {
        public override Direction GetNext()
        {
            return Direction.Right;
        }

        public override Direction GetPrevious()
        {
            return Direction;
        }

        public override List<Direction> GetPreviousConnections()
        {
            Direction[] dirs = { Direction.Up, Direction.Down };
            return new List<Direction>(dirs);
        }

        public override char GetIcon()
        {
            if (Cart != null) return Cart.GetIcon();
            if (Direction.Equals(Direction.Up))
            {
                return '╚';
            }
            else
            {
                return '╔';
            }
        }
    }
}
