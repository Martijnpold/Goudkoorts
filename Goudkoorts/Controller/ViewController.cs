using Goudkoorts.Controller;
using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.View
{
    public class ViewController
    {
        private GameController _gameController;
        private InputView _inputView;
        private OutputView _outputView;

        public ViewController(GameController gamecontroller)
        {
            this._gameController = gamecontroller;
            _inputView = new InputView();
            _outputView = new OutputView();
        }

        public void ShowMainMenu()
        {
            while (true)
            {
                _outputView.PrintWelcomeScreen();
                _outputView.PrintLegenda();
                ConsoleKey input = _inputView.GetKeyPress();
                if (input == ConsoleKey.S) _gameController.PlayLevel();
                if (input == ConsoleKey.Escape) _gameController.QuitGame();
            }
        }

        public void ShowLevel(Map map)
        {
            LevelCreator creator = new LevelCreator();
            creator.Create();
            map = creator.Map;
            while (true)
            {
                _outputView.PrintLevel(map);
                ConsoleKey input = _inputView.GetKeyPress();
                if (input == ConsoleKey.Escape) _gameController.QuitGame();
                if (input == ConsoleKey.D1) _gameController.SwitchJunction(1);
                if (input == ConsoleKey.D2) _gameController.SwitchJunction(2);
                if (input == ConsoleKey.D3) _gameController.SwitchJunction(3);
                if (input == ConsoleKey.D4) _gameController.SwitchJunction(4);
                if (input == ConsoleKey.D5) _gameController.SwitchJunction(5);
                //if(IsCrashed()) GameOver();
            }
        }

        public void ShowGameOver()
        {
            ConsoleKey input = _inputView.GetKeyPress();
            _outputView.PrintGameOver();
            if (input == ConsoleKey.R) _gameController.Start();
            if (input == ConsoleKey.Escape) Environment.Exit(0);
        }

        public void ShowQuitGame()
        {
            _outputView.PrintExitMessage();
            ConsoleKey input = _inputView.GetKeyPress();

            if (input == ConsoleKey.J) Environment.Exit(0);
            else _gameController.Start();
        }
    }
}
