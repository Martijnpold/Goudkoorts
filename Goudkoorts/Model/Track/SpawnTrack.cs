using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class SpawnTrack : TrackBase
    {
        public void Spawn()
        {
            throw new NotImplementedException();
        }

        public override Direction GetNext()
        {
            return Direction.Right;
        }

        public override Direction GetPrevious()
        {
            return Direction.None;
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
            return 'S';
        }
    }
}
