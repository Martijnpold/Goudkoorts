using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    class Floor : Tile
    {
        public override char GetIcon()
        {
            if (TrackOnTop != null) return TrackOnTop.GetIcon();
            return ' ';
        }

        public override ConsoleColor GetBackgroundColor()
        {
            if (TrackOnTop != null) return TrackOnTop.GetBackgroundColor();
            return ConsoleColor.DarkGreen;
        }

        public override ConsoleColor GetColor()
        {
            if (TrackOnTop != null) return TrackOnTop.GetColor();
            return ConsoleColor.White;
        }
    }
}
