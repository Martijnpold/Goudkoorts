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

        public TrackBase Next { get; set; }
        public TrackBase Previous { get; set; }

        public override TrackBase GetNext()
        {
            return Next;
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