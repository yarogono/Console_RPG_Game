using Client.ConsoleUI;
using Client.Controller;
using Client.Models;
using Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Client.Utils.Define;

namespace Client.Managers
{
    public class GameManager
    {
        public void StartGame()
        {
            Player player = MakeSamplePlayer();

            IntroScene(player);
        }


        public void IntroScene(Player player)
        {
            int inputNum = Managers.ConsoleUIManager.ShowIntroMessage();

            switch (inputNum)
            {
                case 1:
                    Managers.ConsoleUIManager.ShowPlayerStatus(player);
                    break;
                case 2:
                    Managers.ConsoleUIManager.ShowInventory(player);
                    break;
                case 3:
                    // TODO : 던전 기능 구현
                    Console.WriteLine("던전은 준비중입니다.");
                    player.Scene = Define.GameScene.Dungeon;
                    break;
                case 4:
                    // TODO : 채팅 기능 구현
                    break;
            }
        }

        private Player MakeSamplePlayer()
        {
            Player player = new Player("유저1", 1, "전사", 10, 5, 100, 1500, Define.GameScene.Town);

            Item ironArmor = new Item(1, "무쇠갑옷", "방어력 +5", Define.ItemType.Ammor, "무쇠로 만들어져 튼튼한 갑옷입니다.");
            Item oldSworld = new Item(2, "낡은 검", "공격력 +2", Define.ItemType.Weapon, "쉽게 볼 수 있는 낡은 검 입니다.");

            player.Inventory = new Inventory();
            player.Inventory.Items.Add(ironArmor) ;
            player.Inventory.Items.Add(oldSworld) ;
            player.Inventory.EquipItem.Add(ironArmor);

            return player;
        }
    }
}
