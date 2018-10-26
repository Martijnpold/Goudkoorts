using Goudkoorts.Model;
using Goudkoorts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Goudkoorts.Controller
{
    class TimeController : BaseThread
    {
        private GameController _gamecontroller;
        private Map _map { get; set; }
        public int NextSpawn { get; set; }
        public double SpawnDelay { get; set; }
        public double TimerFactor { get; set; }

        public TimeController(GameController gamecontroller, Map map, int spawndelay, double timerfactor)
        {
            _gamecontroller = gamecontroller;
            _map = map;

            SpawnDelay = spawndelay;
            NextSpawn = spawndelay;
            TimerFactor = timerfactor;
        }

        public void TickRails()
        {
            List<TrackBase> processed = new List<TrackBase>();
            List<TrackBase> queue = _map.RailEnds;
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

        public void TickSpawn()
        {
            NextSpawn--;
            if (NextSpawn <= 0)
            {
                //_gamecontroller.SpawnCart();
                if(SpawnDelay > 2)
                {
                    SpawnDelay *= TimerFactor;
                    if (SpawnDelay < 2) SpawnDelay = 2;
                }
                NextSpawn = (int) Math.Ceiling(SpawnDelay);
            }
        }

        public override void RunThread()
        {
            while (true)
            {
                Thread.Sleep(1000);
                TickRails();
                TickSpawn();
            }
        }
    }
}
