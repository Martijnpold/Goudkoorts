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
            Tile[,] grid = new Tile[12, 10];
            //Water
            for (int x = 0; x < 12; x++) grid[x, 0] = new SeaRoute();
            //End
            grid[0, 1] = new EndTrack();

            NormalTrack one_one = new NormalTrack();
            NormalTrack two_one = new NormalTrack();
            NormalTrack three_one = new NormalTrack();
            NormalTrack four_one = new NormalTrack();
            NormalTrack five_one = new NormalTrack();
            NormalTrack six_one = new NormalTrack();
            NormalTrack seven_one = new NormalTrack();
            NormalTrack eight_one = new NormalTrack();
            NormalTrack nine_one = new NormalTrack();
            NormalTrack ten_one = new NormalTrack();
            NormalTrack eleven_one = new NormalTrack();
            grid[1, 1] = one;
            grid[2, 1] = two;
            grid[3, 1] = three;
            grid[4, 1] = four;
            grid[5, 1] = five;
            grid[6, 1] = six;
            grid[7, 1] = seven;
            grid[8, 1] = eight;
            grid[9, 1] = nine;
            grid[10, 1] = ten;
            grid[11, 1] = eleven;

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
