using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    class Floor : Tile
    {
        public TrackBase TrackOnTop { get; set; }

        public override char GetIcon()
        {
            return '-';
        }
    }
}
