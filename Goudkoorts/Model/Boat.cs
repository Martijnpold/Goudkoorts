using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public class Boat
    {
        private static readonly int MAX_GOLD = 8;

        private IScoreHolder _scoreholder;
        public bool IsDocked { get; set; }
        public int Gold { get; set; }
        public River River { get; set; }

        public Boat(IScoreHolder scoreholder, River river)
        {
            _scoreholder = scoreholder;
            River = river;
        }

        public void Decouple()
        {
            if (River != null)
            {
                River.Boat = null;
                River = null;
            }
        }

        public void Couple(River river)
        {
            River = river;
            river.Boat = this;
            river.Neighbours[Direction.Down].DockBoat(this);
        }

        public void Tick()
        {
            if (!IsDocked)
            {
                River river = River.Next;
                if(river == null)
                {
                    Reset();
                    return;
                }
                Decouple();
                Couple(river);
                river.Neighbours[Direction.Down].DockBoat(this);
            }
        }

        public void DumpGold(Cart cart)
        {
            if(cart.HasGold)
            {
                cart.HasGold = false;
                Gold++;
                _scoreholder.AddScore(1);
                if (IsFull())
                {
                    River.Neighbours[Direction.Down].Undock();
                    IsDocked = false;
                    _scoreholder.AddScore(10);
                }
            }
        }

        public void Reset()
        {
            River first = River;
            while (first.Previous != null) first = first.Previous;
            Decouple();
            Couple(first);
            Gold = 0;
        }

        public bool IsFull()
        {
            return Gold >= MAX_GOLD;
        }

        public char GetIcon()
        {
            if (IsDocked) return (char) (MAX_GOLD - Gold + 48);
            return '<';
        }
    }
}
