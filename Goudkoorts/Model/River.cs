using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    class River : Tile
    {
        public River Next { get; set; }
        public River Previous { get; set; }

        public override char GetIcon()
        {
            return '~';
        }
    }
}
