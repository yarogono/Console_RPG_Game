using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Managers
{
    public class Managers
    {

        private static Managers s_instance;

        public static Managers GetInstance()
        {
            if (s_instance == null)
            {
                s_instance = new Managers();
            }
            return s_instance;
        }

        private ConsoleUIManager _consoleUIManager = new ConsoleUIManager();
        private GameManager _gameManager = new GameManager();

        public static ConsoleUIManager ConsoleUIManager { get { return GetInstance()._consoleUIManager; } }
        public static GameManager GameManager { get { return GetInstance()._gameManager; } }
    }
}
