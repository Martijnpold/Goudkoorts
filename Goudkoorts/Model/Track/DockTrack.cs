using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class DockTrack : TrackBase
    {
        public override Direction GetNext()
        {
            return Direction.Left;
        }

        public override Direction GetPrevious()
        {
            return Direction.Right;
        }

        public override List<Direction> GetAllConnections()
        {
            throw new NotImplementedException();
        }

        public override void MoveOnTop(Cart cart)
        {
            throw new NotImplementedException();
        }

        public override void Tick()
        {
            throw new NotImplementedException();
        }

        public override char GetIcon()
        {
            return 'D';
        }
    }
}