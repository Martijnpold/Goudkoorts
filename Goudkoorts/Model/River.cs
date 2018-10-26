using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public class River : Tile
    {
        public int Id { get; set; }
        public River Previous { get; set; }
        public River Next { get; set; }

        public Boat Boat { get; set; }

        public void Tick()
        {
            if (Boat != null) Boat.Tick();
        }

        public override char GetIcon()
        {
            if (Boat != null) return Boat.GetIcon();
            return '~';
        }

        public override ConsoleColor GetBackgroundColor()
        {
            return ConsoleColor.DarkBlue;
        }

        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Gray;
        }

        public override void DockBoat(Boat boat)
        {
            return;
        }

        public override void Undock()
        {
            return;
        }
    }
}
