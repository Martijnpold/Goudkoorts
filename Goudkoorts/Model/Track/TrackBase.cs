using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public abstract class TrackBase
    {
        public Cart Cart { get; set; }

        public abstract Direction GetNext();

        public abstract Direction GetPrevious();

        public abstract List<Direction> GetAllConnections();

        public abstract void MoveOnTop(Cart cart);

        public abstract void Tick();

        public abstract char GetIcon();
    }
}