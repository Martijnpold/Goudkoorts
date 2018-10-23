using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public abstract class JunctionBase : TrackBase
    {
        public int Id { get; set; }
        public Direction Direction { get; private set; }

        public void Switch()
        {
            if(Direction.Equals(Direction.Up))
            {
                Direction = Direction.Down;
            } else
            {
                Direction = Direction.Up;
            }
        }

        public override void MoveOnTop(Cart cart)
        {
            throw new NotImplementedException();
        }

        public override void Tick()
        {
            throw new NotImplementedException();
        }
    }
}