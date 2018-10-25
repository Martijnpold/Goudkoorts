﻿using Goudkoorts.Model;
using Goudkoorts.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Controller
{
    public class GameController
    {
        private InputView _inputView;
        private OutputView _outputView;
        private TimeController _timerController;
        public Map Map { get; set; }

        public GameController()
        {
            _inputView = new InputView();
            _outputView = new OutputView();
            _timerController = new TimeController();

            Start();
        }

        public void Start()
        {
            while (true)
            {
                _outputView.PrintWelcomeScreen();
                _outputView.PrintLegenda();
                ConsoleKey input = _inputView.GetKeyPress();
                if (input == ConsoleKey.S) PlayLevel();
                if (input == ConsoleKey.Escape) QuitGame();
            }
        }

        public void PlayLevel()
        {
            LevelCreator creator = new LevelCreator();
            creator.Create();
            Map = creator.Map;
            while (true)
            {
                _outputView.PrintLevel(Map);
                ConsoleKey input = _inputView.GetKeyPress();
                if (input == ConsoleKey.Escape) QuitGame();
                if (input == ConsoleKey.D1) Map.SwitchJunction(1);
                if (input == ConsoleKey.D2) Map.SwitchJunction(2);
                if (input == ConsoleKey.D3) Map.SwitchJunction(3);
                if (input == ConsoleKey.D4) Map.SwitchJunction(4);
                if (input == ConsoleKey.D5) Map.SwitchJunction(5);
                //if(IsCrashed()) GameOver();
            }
        }

        // Game Finished = When a cart has a collision with another cart
        //public bool IsCrashed()
        //{
        //    return //if carts have crashed or nah.
        //}

        public void GameOver()
        {
            ConsoleKey input = _inputView.GetKeyPress();
            _outputView.PrintGameOver();
            if (input == ConsoleKey.R) Start();
            if (input == ConsoleKey.Escape) Environment.Exit(0);

        }

        // Exit Game
        public void QuitGame()
        {
            System.Console.Clear();
            Console.WriteLine("weet je zeker dat je wilt stoppen? (J / N)");

            ConsoleKey input = _inputView.GetKeyPress();

            if (input == ConsoleKey.J) Environment.Exit(0);
            else Start();
        }
    }
}
