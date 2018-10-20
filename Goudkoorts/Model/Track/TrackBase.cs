using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public abstract class TrackBase : Tile
    {
        public Cart Cart { get; set; }

        public abstract TrackBase GetNext();

        public abstract TrackBase GetPrevious();

        public abstract void MoveOnTop(Cart cart);

        public abstract void Tick();
    }
}