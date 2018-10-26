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
            _timerController = new TimeController();
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

            _viewController.ShowLevel(Map);
        }

        // Game Finished = When a cart has a collision with another cart
        //public bool IsCrashed()
        //{
        //    return //if carts have crashed or nah.
        //}

        public void GameOver()
        {
            _viewController.ShowGameOver();
        }

        // Switch Junction method
        public void SwitchJunction(int id)
        {
            foreach (JunctionBase junction in Map.Junctions)
            {
                if (junction.Id == id) junction.Switch();
            }
        }

        // Exit Game
        public void QuitGame()
        {
            _viewController.ShowQuitGame();
        }
    }
}
