using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class SpawnTrack : TrackBase
    {
        public void Spawn()
        {
            Cart = new Cart(this);
        }

        public override Direction GetNext()
        {
            return Direction.Right;
        }

        public override Direction GetPrevious()
        {
            return Direction.None;
        }

        public override List<Direction> GetPreviousConnections()
        {
            Direction[] directions = new Direction[] { GetNext() };
            return new List<Direction>(directions);
        }

        public override void MoveOnTop(Cart cart, Direction dir)
        {
            if (Cart == null)
            {
                cart.Decouple();
                cart.Couple(this);
            }
        }

        public override void DockBoat(Boat boat)
        {
            return;
        }

        public override void Undock()
        {
            return;
        }

        public override void Tick()
        {
            if (Cart != null)
            {
                Tile tile = Tile.Neighbours[GetNext()];
                tile.MoveCartOnTop(Cart, GetNext());
            }
        }

        public override char GetIcon()
        {
            if (Cart != null) return Cart.GetIcon();
            return 'S';
        }

        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Yellow;
        }

        public override ConsoleColor GetBackgroundColor()
        {
            return ConsoleColor.DarkGreen;
        }
    }
}
