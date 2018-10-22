using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.View
{
    public class InputView
    {
        public ConsoleKey getKeyPress()
        {
            return Console.ReadKey().Key;
        }
    }
}
