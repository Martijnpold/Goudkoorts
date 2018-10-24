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

        public void PrintMap(Map map)
        {

        }

        public void WelcomeScreen()
        {
            System.Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                Welkom Bij Goudkoorts!                ║");
            Console.WriteLine("║            Druk op een toets om te beginnen          ║");
            Console.WriteLine("║                Druk op S om te stoppen               ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.WriteLine("");
            Console.ReadLine();
        }

        public void IntroLegenda()
        {
            System.Console.Clear();
            Console.WriteLine("╔════════════════════════════════╦═════════════════════╗");
            Console.WriteLine("║    betekenis van de symbolen   ║  doel van het spel  ║");
            Console.WriteLine("║                                ║                     ║");
            Console.WriteLine("║      ═ ║  : rail               ║  verzamel punten    ║");
            Console.WriteLine("║      ╝ ╗  : right junction     ║    door goud te     ║");
            Console.WriteLine("║      ╚ ╔  : left junction      ║     verzamelen      ║");
            Console.WriteLine("║       U   : karretje           ║                     ║");
            Console.WriteLine("║       Ü   : gevuld karretje    ║                     ║");
            Console.WriteLine("║       _   : safe track         ║                     ║");
            Console.WriteLine("║       ~   : zee                ║                     ║");
            Console.WriteLine("║       S   : spawn point        ║                     ║");
            Console.WriteLine("║       D   : dock               ║                     ║");
            Console.WriteLine("╚════════════════════════════════╩═════════════════════╝");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
