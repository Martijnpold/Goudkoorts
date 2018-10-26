using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public abstract class JunctionBase : TrackBase
    {
        public int Id { get; set; }
        public Direction Direction { get; private set; }

        public void Switch()
        {
            if (Cart != null) return;
            if (Direction == Direction.Up)
            {
                Direction = Direction.Down;
            }
            else
            {
                Direction = Direction.Up;
            }
        }

        public override void MoveOnTop(Cart cart, Direction dir)
        {
            Direction from = DirectionUtils.GetOpposite(dir);
            Direction prev = GetPrevious();
            if (prev == from)
            {
                if (Cart == null)
                {
                    cart.Decouple();
                    cart.Couple(this);
                }
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