using Goudkoorts.Utils;
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

        public override Direction GetNext()
        {
            return Out;
        }

        public override Direction GetPrevious()
        {
            return In;
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
            }
            else
            {
                throw new CartCrashException();
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
                Tile tile = Tile.Neighbours[Out];
                tile.MoveCartOnTop(Cart, Out);
            }
        }

        public override char GetIcon()
        {
            if (Cart != null) return Cart.GetIcon();
            if (In.Equals(Direction.Up))
            {
                if (Out.Equals(Direction.Right)) return '╚';
                if (Out.Equals(Direction.Down)) return '║';
                if (Out.Equals(Direction.Left)) return '╝';
            }
            if (In.Equals(Direction.Right))
            {
                if (Out.Equals(Direction.Up)) return '╚';
                if (Out.Equals(Direction.Down)) return '╔';
                if (Out.Equals(Direction.Left)) return '═';
            }
            if (In.Equals(Direction.Down))
            {
                if (Out.Equals(Direction.Up)) return '║';
                if (Out.Equals(Direction.Right)) return '╔';
                if (Out.Equals(Direction.Left)) return '╗';
            }
            if (In.Equals(Direction.Left))
            {
                if (Out.Equals(Direction.Up)) return '╝';
                if (Out.Equals(Direction.Right)) return '═';
                if (Out.Equals(Direction.Down)) return '╗';
            }
            return '*';
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