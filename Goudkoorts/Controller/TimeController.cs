using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Controller
{
    class TimeController
    {
        public Map Map { get; set; }

        public void DoTick()
        {
            List<TrackBase> processed = new List<TrackBase>();
            List<TrackBase> queue = Map.RailEnds;
            while (queue.Count > 0)
            {
                TrackBase toProcess = queue[0];
                Tile processedTile = toProcess.Tile;
                toProcess.Tick();
                queue.RemoveAt(0);
                foreach (Direction connection in toProcess.GetAllConnections())
                {
                    Tile neighbour = processedTile.Neighbours[connection];
                    if (neighbour.TrackOnTop != null && !processed.Contains(neighbour.TrackOnTop))
                        queue.Add(neighbour.TrackOnTop);
                }
            }
        }
    }
}
