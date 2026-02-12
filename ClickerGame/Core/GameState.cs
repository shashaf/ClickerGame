using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame.Core
{
    public class GameState
    {
        private static GameState _instance; // поле для экземпляра

        public static GameState Instance // метод доступа к экземпляру
        {
            get
            {
                if (_instance == null)
                    _instance = new GameState();

                return _instance;
            }
        }

        // Игровые параметры
        public int Score { get; private set; } = 0;
        public int ClickPower { get; private set; } = 1;
        public int AutoClickPower { get; private set; } = 0;

        public int UpgradeCost { get; private set; } = 10;
        public int AutoClickUpgradeCost { get; private set; } = 300;

        private GameState() { } // закрытый конструктор

        public void AddClick()
        {
            Score += ClickPower;
        }

        public void AutoClick() 
        {
            Score += AutoClickPower;
        }

        public bool BuyUpgrade()
        {
            if (Score < UpgradeCost)
                return false;

            Score -= UpgradeCost;
            ClickPower++;
            UpgradeCost += 10;

            // Проверяем отдельно покупку автоклика
            if (Score >= AutoClickUpgradeCost)
            {
                Score -= AutoClickUpgradeCost;
                AutoClickPower++;
                AutoClickUpgradeCost *= 2;
            }

            return true;
        }

        public void Reset()
        {
            Score = 0;
            ClickPower = 1;
            AutoClickPower = 0;
            UpgradeCost = 10;
        }
    }
}
