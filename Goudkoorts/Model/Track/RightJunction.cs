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
            return Direction;
        }

        public override Direction GetPrevious()
        {
            return Direction.Left;
        }

        public override List<Direction> GetPreviousConnections()
        {
            Direction[] dirs = { Direction.Left };
            return new List<Direction>(dirs);
        }

        public override char GetIcon()
        {
            if (Cart != null) return Cart.GetIcon();
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
