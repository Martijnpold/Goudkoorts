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
            return Direction;
        }

        public override Direction GetPrevious()
        {
            return Direction.Left;
        }

        public override List<Direction> GetAllConnections()
        {
            Direction[] dirs = { Direction.Left, Direction.Up, Direction.Down };
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
