using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public abstract class Tile
    {
        public TrackBase TrackOnTop { get; set; }

        public Dictionary<Direction, Tile> Neighbours { get; set; }

        public abstract char GetIcon();

        public Tile()
        {
            Neighbours = new Dictionary<Direction, Tile>();
        }

        public void MoveCartOnTop(Cart cart, Direction dir)
        {
            if (TrackOnTop == null) return;
            TrackOnTop.MoveOnTop(cart, dir);
        }

        public abstract ConsoleColor GetColor();

        public abstract ConsoleColor GetBackgroundColor();
    }
}
