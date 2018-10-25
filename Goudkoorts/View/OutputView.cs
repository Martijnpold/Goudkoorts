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
        public void PrintLevel()
        {
            System.Console.Clear();
            LevelCreator p = new LevelCreator();
            p.Create();
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
            Console.WriteLine("║       Ü   : gevuld karretje    ║                     ║");
            Console.WriteLine("║       _   : safe track         ║                     ║");
            Console.WriteLine("║       x   : cart on safe track ║                     ║");
            Console.WriteLine("║       ~   : zee                ║                     ║");
            Console.WriteLine("║       S   : spawn point        ║                     ║");
            Console.WriteLine("║      <*>  : ship               ║ * = amount of gold  ║");
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
    }
}
