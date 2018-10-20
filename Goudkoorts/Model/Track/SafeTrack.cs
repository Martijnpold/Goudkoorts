using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class SafeTrack : TrackBase
    {
        public override TrackBase GetNext()
        {
            throw new NotImplementedException();
        }

        public override TrackBase GetPrevious()
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
            throw new NotImplementedException();
        }
    }
}