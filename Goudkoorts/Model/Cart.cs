using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public class Cart
    {
        public bool HasGold { get; set; }
        public TrackBase Track { get; set; }

        public Cart(TrackBase track)
        {
            Track = track;
            HasGold = true;
        }

        public void Decouple()
        {
            if (Track != null)
            {
                Track.Cart = null;
                Track = null;
            }
        }

        public void Couple(TrackBase track)
        {
            Track = track;
            track.Cart = this;
        }

        public char GetIcon()
        {
            if (HasGold) return 'Û';
            return 'U';
        }
    }
}
