using Goudkoorts.Controller;
using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts
{
    class Program
    {
        static void Main(string[] args)
        {
            LevelCreator p = new LevelCreator();
            p.Create();
            Console.ReadLine();
        }
    }
}
