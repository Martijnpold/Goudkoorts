﻿using System;
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
            if(Direction.Equals(Direction.Up))
            {
                Direction = Direction.Down;
            } else
            {
                Direction = Direction.Up;
            }
        }

        public override void MoveOnTop(Cart cart, Direction dir)
        {
            Direction from = DirectionUtils.GetOpposite(dir);
            if(GetPrevious().Equals(from))
            {
                Cart = cart;
            }
        }

        public override void Tick()
        {
            if (Cart != null)
            {
                Tile tile = Tile.Neighbours[GetNext()];
                tile.MoveCartOnTop(Cart, GetNext());
            }
        }
    }
}