using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class NormalTrack : TrackBase
    {
        public Direction In { get; set; }
        public Direction Out { get; set; }

        public override Direction GetNext()
        {
            return Out;
        }

        public override Direction GetPrevious()
        {
            return In;
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
            if(In.Equals(Direction.Up))
            {
                if (Out.Equals(Direction.Right)) return '╚';
                if (Out.Equals(Direction.Down)) return '║';
                if (Out.Equals(Direction.Left)) return '╝';
            }
            if (In.Equals(Direction.Right))
            {
                if (Out.Equals(Direction.Up)) return '╚';
                if (Out.Equals(Direction.Down)) return '╔';
                if (Out.Equals(Direction.Left)) return '═';
            }
            if (In.Equals(Direction.Down))
            {
                if (Out.Equals(Direction.Up)) return '║';
                if (Out.Equals(Direction.Right)) return '╔';
                if (Out.Equals(Direction.Left)) return '╗';
            }
            if (In.Equals(Direction.Left))
            {
                if (Out.Equals(Direction.Up)) return '╝';
                if (Out.Equals(Direction.Right)) return '═';
                if (Out.Equals(Direction.Down)) return '╗';
            }
            return '*';
        }
    }
}