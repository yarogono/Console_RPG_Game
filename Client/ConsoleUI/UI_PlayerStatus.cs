using Client.Models;
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

            string playerStatusStr = "상태보기\n" +
                                            "캐릭터의 정보로 표시합니다.\n" +
                                            "\n" +
                                            $"Lv.{player.Level}\n" +
                                            $"{player.Name}({player.CharacterClass})\n" +
                                            $"공격력 :{player.Attack}\n" +
                                            $"방어력 : {player.Defense}\n" +
                                            $"체력 : {player.Hp}\n" +
                                            $"Gold : {player.Gold} G\n" +
                                            $"\n" +
                                            $"0. 나가기\n" +
                                            $"원하시는 행동을 입력해주세요.\n" +
                                            $">> ";


            Console.Write(playerStatusStr);
        }
    }
}
