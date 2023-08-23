using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ConsoleUI
{
    public class UI_Intro
    {
        public void PrintIntro()
        {
            Console.Clear();
            string introMessage =    "게임에 오신 여러분 환영합니다.\r\n" +
                                             "이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.\r\n\r\n" +
                                             "1. 상태 보기\r\n" +
                                             "2. 인벤토리\r\n" +
                                             "3. 던전으로 이동\r\n" +
                                             "\r\n" +
                                             "원하시는 행동을 입력해주세요.\r\n>> ";

            Console.Write(introMessage);
        }
    }
}
