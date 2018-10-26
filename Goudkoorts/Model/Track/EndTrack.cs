using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class EndTrack : TrackBase
    {
        public override Direction GetNext()
        {
            return Direction.None;
        }

        public override Direction GetPrevious()
        {
            return Direction.Right;
        }

        public override List<Direction> GetAllConnections()
        {
            Direction[] directions = new Direction[] { GetPrevious() };
            return new List<Direction>(directions);
        }

        public override void MoveOnTop(Cart cart, Direction dir)
        {
            if (Cart == null)
            {
                cart.Decouple();
                Cart = cart;
            }
        }

        public override void Tick()
        {
            if (Cart != null) Cart.Decouple();
        }

        public override char GetIcon()
        {
            if (Cart != null) return Cart.GetIcon();
            return '#';
        }

        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Red;
        }

        public override ConsoleColor GetBackgroundColor()
        {
            return ConsoleColor.DarkGreen;
        }
    }
}
