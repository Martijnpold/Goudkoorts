using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class DockTrack : TrackBase
    {
        public Boat Boat { get; set; }

        public override Direction GetNext()
        {
            return Direction.Left;
        }

        public override Direction GetPrevious()
        {
            return Direction.Right;
        }

        public override List<Direction> GetPreviousConnections()
        {
            Direction[] directions = new Direction[] { GetPrevious() };
            return new List<Direction>(directions);
        }

        public override void MoveOnTop(Cart cart, Direction dir)
        {
            if (Cart == null)
            {
                cart.Decouple();
                cart.Couple(this);
                if (Boat != null)
                    Boat.DumpGold(cart);
            }
        }

        public override void DockBoat(Boat boat)
        {
            Boat = boat;
            boat.IsDocked = true;
        }

        public override void Undock()
        {
            Boat = null;
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
            return 'D';
        }

        public override ConsoleColor GetColor()
        {
            return ConsoleColor.White;
        }

        public override ConsoleColor GetBackgroundColor()
        {
            return ConsoleColor.DarkGreen;
        }
    }
}