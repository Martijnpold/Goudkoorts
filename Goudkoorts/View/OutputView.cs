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
            Console.WriteLine("╔════════════════════════════════╦═════════════════════╗");
            Console.WriteLine("║    Welkom Bij Goudkoorts!      ║                     ║");
            Console.WriteLine("║                                ║                     ║");
            Console.WriteLine("║    betekenis van de symbolen   ║  doel van het spel  ║");
            Console.WriteLine("║                                ║                     ║");
            Console.WriteLine("║         # : rail               ║  verzamel punten    ║");
            Console.WriteLine("║         - : vloer              ║  door karretjes     ║");
            Console.WriteLine("║         ~ : zee                ║  aan te laten komen ║");
            Console.WriteLine("║         + : junction           ║  op de bestemming   ║");
            Console.WriteLine("╚════════════════════════════════╩═════════════════════╝");
            Console.WriteLine("");
            Console.WriteLine("> Kies een level (1 - 6) s = stop");
            Console.WriteLine("");  
            Console.ReadLine();
        }
    }
}
