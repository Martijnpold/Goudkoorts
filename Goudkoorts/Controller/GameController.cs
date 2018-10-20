using Goudkoorts.Model;
using Goudkoorts.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Controller
{
    class GameController
    {
        private InputView _inputview;
        private OutputView _outputview;
        private SpawnTimerController _timerController;
        public Map Map { get; set; }

        public void Start()
        {
            //_viewController.ShowMenu();
        }
    }
}
