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

        public void Decouple()
        {
            if (Track != null)
            {
                Track.Cart = null;
                Track = null;
            }
        }

        public char GetIcon()
        {
            if (HasGold) return 'Û';
            return 'U';
        }

    }
}
