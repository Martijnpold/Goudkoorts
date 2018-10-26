using Goudkoorts.Controller;
using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.View
{
    public class OutputView
    {
        public void PrintLevel(Map map)
        {
            Console.Clear();
            Tile x, y;
            bool xDone, yDone;
            y = map.Corner;
            yDone = false;
            while (!yDone)
            {
                x = y;
                xDone = false;
                while (!xDone)
                {
                    Console.Write(x.GetIcon());
                    xDone = !x.Neighbours.ContainsKey(Direction.Right);
                    if (!xDone) x = x.Neighbours[Direction.Right];
                }
                Console.Write("\n");
                yDone = !y.Neighbours.ContainsKey(Direction.Down);
                if (!yDone) y = y.Neighbours[Direction.Down];
            }
        }

        public void PrintWelcomeScreen()
        {
            System.Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                Welkom Bij Goudkoorts!                ║");
            Console.WriteLine("║              Druk op 's' om te beginnen              ║");
            Console.WriteLine("║               Druk op ESC om te stoppen              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.WriteLine("");
        }

        public void PrintLegenda()
        {
            Console.WriteLine("╔════════════════════════════════╦═════════════════════╗");
            Console.WriteLine("║    betekenis van de symbolen   ║  doel van het spel  ║");
            Console.WriteLine("║                                ║                     ║");
            Console.WriteLine("║      ═ ║  : rail               ║  verzamel punten    ║");
            Console.WriteLine("║      ╝ ╗  : right junction     ║    door goud te     ║");
            Console.WriteLine("║      ╚ ╔  : left junction      ║     verzamelen      ║");
            Console.WriteLine("║       U   : karretje           ║                     ║");
            Console.WriteLine("║       Û   : gevuld karretje    ║                     ║");
            Console.WriteLine("║       _   : safe track         ║                     ║");
            Console.WriteLine("║       x   : cart on safe track ║                     ║");
            Console.WriteLine("║       ~   : zee                ║                     ║");
            Console.WriteLine("║       S   : spawn point        ║                     ║");
            Console.WriteLine("║       <  : ship                ║                     ║");
            Console.WriteLine("║       D   : dock               ║                     ║");
            Console.WriteLine("║       #   : end track          ║                     ║");
            Console.WriteLine("╚════════════════════════════════╩═════════════════════╝");
            Console.WriteLine("");
        }

        public void PrintGameOver()
        {
            System.Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                        Game Over!                    ║");
            Console.WriteLine("║            Druk op 'r' om overnieuw te spelen        ║");
            Console.WriteLine("║                Druk op 'ESC' om te stoppen           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.WriteLine("");
        }

        public void PrintJunctionLegenda()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║            1       2       3       4       5         ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.WriteLine("");
        }
        public void PrintExitMessage()
        {
            System.Console.Clear();
            Console.WriteLine("weet je zeker dat je wilt stoppen? (J / N)");
            Console.WriteLine("");
        }
    }

}
