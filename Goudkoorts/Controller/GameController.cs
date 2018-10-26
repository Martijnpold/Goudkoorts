using Goudkoorts.Model;
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
        private ViewController _viewController;   
        private TimeController _timerController;
        public Map Map { get; set; }

        public GameController()
        {
            _viewController = new ViewController(this);
            Start();
        }

        public void Start()
        {
            _viewController.ShowMainMenu();
        }

        public void PlayLevel()
        {
            LevelCreator creator = new LevelCreator();
            creator.Create();
            Map = creator.Map;

            if (_timerController != null) _timerController.StopThread();
            _timerController = new TimeController(this, Map, 10, 0.9, 2000);
            _timerController.Start();

            _viewController.ShowLevel(Map);
            while (!Map.GameOver)
            {
                _viewController.DoMove();
            }
            GameOver();
        }

        public void GameOver()
        {
            _viewController.ShowGameOver(Map.GetScore());
        }

        public void Crashed()
        {
            Map.GameOver = true;
        }

        public void SpawnCart()
        {
            Random r = new Random();
            int index = r.Next(0, Map.Spawns.Count);
            SpawnTrack spawn = Map.Spawns[index];
            spawn.Spawn();
        }

        public void UpdateMap()
        {
            _viewController.ShowLevel(Map);
        }

        // Switch Junction method
        public void SwitchJunction(int id)
        {
            foreach (JunctionBase junction in Map.Junctions)
            {
                if (junction.Id == id) junction.Switch();
            }
            UpdateMap();
        }

        // Exit Game
        public void QuitGame()
        {
            _viewController.ShowQuitGame();
        }
    }
}
