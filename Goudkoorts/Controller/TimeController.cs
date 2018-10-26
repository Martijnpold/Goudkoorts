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
        public int SpawnDelay { get; set; }
        public int NextSpawn { get; set; }

        public double TimerFactor { get; set; }
        public int Interval { get; set; }

        public TimeController(GameController gamecontroller, Map map, int spawndelay, double timerfactor, int interval)
        {
            _gamecontroller = gamecontroller;
            _map = map;

            SpawnDelay = spawndelay;
            NextSpawn = spawndelay;
            TimerFactor = timerfactor;
            Interval = interval;
        }

        private void TickRails()
        {
            List<Cart> processedCarts = new List<Cart>();
            List<TrackBase> processed = new List<TrackBase>();
            List<TrackBase> queue = new List<TrackBase>(_map.RailEnds);
            while (queue.Count > 0)
            {
                TrackBase toProcess = queue[0];
                queue.RemoveAt(0);

                if (processed.Contains(toProcess)) continue;
                processed.Add(toProcess);
                if (toProcess.Cart != null && processedCarts.Contains(toProcess.Cart)) continue;
                if (toProcess.Cart != null) processedCarts.Add(toProcess.Cart);
                toProcess.Tick();

                Tile processedTile = toProcess.Tile;
                foreach (Direction connection in toProcess.GetPreviousConnections())
                {
                    if (!processedTile.Neighbours.ContainsKey(connection)) continue;

                    Tile neighbour = processedTile.Neighbours[connection];
                    if (neighbour.TrackOnTop != null)
                        queue.Add(neighbour.TrackOnTop);
                }
            }
        }

        private void TickSpawn()
        {
            NextSpawn--;
            if (NextSpawn <= 0)
            {
                _gamecontroller.SpawnCart();
                Interval = (int) (Interval * TimerFactor);
                NextSpawn = SpawnDelay;
            }
        }

        private void TickRiver()
        {
            River river = _map.RiverEnd;
            while(river.Previous != null)
            {
                river.Tick();
                river = river.Previous;
            }
            river.Tick();
        }

        public override void RunThread()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        Thread.Sleep(Interval);
                        TickRiver();
                        TickRails();
                        TickSpawn();
                        _gamecontroller.UpdateMap();
                    }
                    catch (ThreadInterruptedException) { }
                }
            }
            catch (CartCrashException)
            {
                _gamecontroller.Crashed();
            }
        }
    }
}
