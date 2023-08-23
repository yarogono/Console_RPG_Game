using Client.ConsoleUI;
using Client.Controller;
using Client.Models;

namespace Client.Managers
{
    public class ConsoleUIManager
    {
        UI_Inventory _inventory = new UI_Inventory();
        UI_PlayerStatus _playerStatus = new UI_PlayerStatus();
        UI_Intro _intro = new UI_Intro();
        

        public int ShowIntroMessage()
        {
            _intro.PrintIntro();

            int inputNum = CheckValidIntroInputNum(1, 2);

            return inputNum;
        }

        public void ShowPlayerStatus(Player player)
        {
            _playerStatus.PrintPlayerStatus(player);

            int inputNum = CheckValidIntroInputNum(0, 0);

            if (inputNum == 0)
                Managers.GameManager.IntroScene(player);
        }

        public void ShowInventory(Player player)
        {
            _inventory.PrintPlayerInventoryInfo(player);

            int inputNum = CheckValidIntroInputNum(0, 1);

            if (inputNum == 0)
                Managers.GameManager.IntroScene(player);
            else if (inputNum == 1)
                ShowInventoryEquip(player);
        }

        public void ShowInventoryEquip(Player player)
        {
            _inventory.PlayerItemEquip(player);

            int inputNum  = CheckValidIntroInputNum(0, player.Inventory.Items.Count + 1);

            if (inputNum == 0)
                Managers.GameManager.IntroScene(player);
            
            if (inputNum >= 1)
            {
                int itemNum = inputNum - 1;

                Item item = player.Inventory.Items[itemNum];
                if (player.Inventory.EquipItem.Contains(item))
                    InventoryController.UnEquipItem(player, item);
                else
                    InventoryController.EquipItem(player, item);
                

                Managers.ConsoleUIManager.ShowInventory(player);
            }
        }

        private int CheckValidIntroInputNum(int min, int max)
        {
            int inputNum = 0;
            while (true)
            {
                bool isNum = int.TryParse(Console.ReadLine(), out inputNum);
                if (isNum == false || inputNum < min || inputNum > max)
                {
                    Console.Write("잘못된 입력입니다.\n" +
                                       "다시 원하시는 행동을 입력해주세요\r\n>> ");
                    continue;
                }
                break;
            }
            return inputNum;
        }
    }
}
