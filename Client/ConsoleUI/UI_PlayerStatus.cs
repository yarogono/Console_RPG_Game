using Client.Models;
using Client.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ConsoleUI
{
    public class UI_PlayerStatus
    {
        public void PrintPlayerStatus(Player player)
        {
            Console.Clear();

            StringBuilder sb = new StringBuilder();

            sb.Append("상태보기\n" +
                           "캐릭터의 정보로 표시합니다.\n" +
                           "\r\n" +
                          $"Lv.{player.Level}\n" +
                          $"{player.Name}({player.CharacterClass})\n");

            if (player.Inventory.EquipItem.Count >= 1)
            {
                int attack = 0;
                int defense = 0;
                foreach (Item item in player.Inventory.EquipItem)
                {
                    string[] statStr = item.Stat.Split();
                    if (statStr.Contains("공격력"))
                    {
                        int statNum = int.Parse(statStr[1].Replace('+', ' '));
                        attack += statNum;
                    }
                    else if (statStr.Contains("방어력"))
                    {
                        int statNum = int.Parse(statStr[1].Replace('+', ' '));
                        defense += statNum;
                    }
                }
                
                sb.Append($"공격력 :{player.Attack} (+{attack})\n" +
                              $"방어력 : {player.Defense} (+{defense})\n");
            }
            else
            {
                sb.Append($"공격력 :{player.Attack}\n" +
                               $"방어력 : {player.Defense}\n");
            }


            sb.Append($"체력 : {player.Hp}\n" +
                           $"Gold : {player.Gold} G\n" +
                           $"\r\n" +
                           $"0. 나가기\n" +
                           $"원하시는 행동을 입력해주세요.\n" +
                           $">> ");


            Console.Write(sb.ToString());
        }
    }
}
