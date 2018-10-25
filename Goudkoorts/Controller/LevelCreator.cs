using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Controller
{
    class LevelCreator
    {
        public Map Map { get; set; }

        public void Create()
        {
            Map = new Map();
            Tile[,] grid = new Tile[12, 10];
            //Water
            River[] rivers = new River[12];
            for (int x = 0; x < 12; x++)
            {
                River river = new River();
                if (x == 0)
                {
                    Map.Corner = river;
                }
                else
                {
                    river.Previous = rivers[x - 1];
                    rivers[x - 1].Next = river;
                }
                grid[x, 0] = river;
                rivers[x] = river;
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 12; x++)
                {
                    Tile tile = grid[x, y];
                    if (tile == null)
                    {
                        grid[x, y] = new Floor();
                    }
                }
            }

            //End
            //#<<<<<<<<D<<
            EndTrack endTrack = new EndTrack();
            grid[0, 1].TrackOnTop = endTrack;
            grid[1, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[2, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[3, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[4, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[5, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[6, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[7, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[8, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[9, 1].TrackOnTop = new DockTrack();
            grid[10, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[11, 1].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Down };
            //___________^
            grid[11, 2].TrackOnTop = new NormalTrack() { Out = Direction.Up, In = Direction.Down };
            //S>>V_>>>>V_^
            grid[0, 3].TrackOnTop = new SpawnTrack();
            grid[1, 3].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[2, 3].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[3, 3].TrackOnTop = new NormalTrack() { Out = Direction.Down, In = Direction.Left };
            grid[5, 3].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Down };
            grid[6, 3].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[7, 3].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[8, 3].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[9, 3].TrackOnTop = new NormalTrack() { Out = Direction.Down, In = Direction.Left };
            grid[11, 3].TrackOnTop = new NormalTrack() { Out = Direction.Up, In = Direction.Down };
            //___L>R___L>^
            JunctionBase junc = new LeftJunction() { Id = 1 };
            Map.Junctions.Add(junc);
            grid[3, 4].TrackOnTop = junc;
            grid[4, 4].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            junc = new RightJunction() { Id = 2 };
            Map.Junctions.Add(junc);
            grid[5, 4].TrackOnTop = junc;
            junc = new LeftJunction() { Id = 3 };
            Map.Junctions.Add(junc);
            grid[9, 4].TrackOnTop = junc;
            grid[10, 4].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[11, 4].TrackOnTop = new NormalTrack() { Out = Direction.Up, In = Direction.Left };
            //S>>^_>V_>^__
            grid[0, 5].TrackOnTop = new SpawnTrack();
            grid[1, 5].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[2, 5].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[3, 5].TrackOnTop = new NormalTrack() { Out = Direction.Up, In = Direction.Left };
            grid[5, 5].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Up };
            grid[6, 5].TrackOnTop = new NormalTrack() { Out = Direction.Down, In = Direction.Left };
            grid[8, 5].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Down };
            grid[9, 5].TrackOnTop = new NormalTrack() { Out = Direction.Up, In = Direction.Left };
            //______L>R___
            junc = new LeftJunction() { Id = 4 };
            Map.Junctions.Add(junc);
            grid[6, 6].TrackOnTop = junc;
            grid[7, 6].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            junc = new RightJunction() { Id = 5 };
            Map.Junctions.Add(junc);
            grid[8, 6].TrackOnTop = junc;
            //S>>>>>^_>>>V
            grid[0, 7].TrackOnTop = new SpawnTrack();
            grid[1, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[2, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[3, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[4, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[5, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[6, 7].TrackOnTop = new NormalTrack() { Out = Direction.Up, In = Direction.Left };
            grid[8, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Up };
            grid[9, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[10, 7].TrackOnTop = new NormalTrack() { Out = Direction.Right, In = Direction.Left };
            grid[11, 7].TrackOnTop = new NormalTrack() { Out = Direction.Down, In = Direction.Left };
            //___________V
            grid[11, 8].TrackOnTop = new NormalTrack() { Out = Direction.Down, In = Direction.Up };
            //=========<<<
            SafeTrack endSafeTrack = new SafeTrack();
            grid[0, 9].TrackOnTop = endSafeTrack;
            grid[1, 9].TrackOnTop = new SafeTrack();
            grid[2, 9].TrackOnTop = new SafeTrack();
            grid[3, 9].TrackOnTop = new SafeTrack();
            grid[4, 9].TrackOnTop = new SafeTrack();
            grid[5, 9].TrackOnTop = new SafeTrack();
            grid[6, 9].TrackOnTop = new SafeTrack();
            grid[7, 9].TrackOnTop = new SafeTrack();
            grid[8, 9].TrackOnTop = new SafeTrack();
            grid[9, 9].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[10, 9].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Right };
            grid[11, 9].TrackOnTop = new NormalTrack() { Out = Direction.Left, In = Direction.Up };

            Map.RailEnds.Add(endSafeTrack);
            Map.RailEnds.Add(endSafeTrack);

            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    Tile tile = grid[x, y];
                    if (tile.TrackOnTop != null) tile.TrackOnTop.Tile = tile;
                    foreach (Direction dir in Enum.GetValues(typeof(Direction)))
                    {
                        int x1 = x;
                        int y1 = y;

                        switch (dir)
                        {
                            case Direction.Up:
                            y1--;
                            break;
                            case Direction.Right:
                            x1++;
                            break;
                            case Direction.Down:
                            y1++;
                            break;
                            case Direction.Left:
                            x1--;
                            break;
                        }

                        if (x1 >= 0 && x1 < grid.GetLength(0))
                            if (y1 >= 0 && y1 < grid.GetLength(1))
                                tile.Neighbours[dir] = grid[x1, y1];
                    }
                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 12; x++)
                {
                    Tile tile = grid[x, y];
                    if (tile != null)
                    {
                        Console.Write(tile.GetIcon());
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

