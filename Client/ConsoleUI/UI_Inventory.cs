using Client.Models;
using System.Text;

namespace Client.ConsoleUI
{
    public class UI_Inventory
    {
        private StringBuilder _sb = new StringBuilder();

        public void PrintPlayerInventoryInfo(Player player)
        {
            Console.Clear();
            _sb.Clear();

            _sb.Append("인벤토리\n" +
                           "보유 중인 아이템을 관리할 수 있습니다.\r\n" +
                           "\r\n" +
                           "[아이템 목록]\r\n");


            AppendPlayerItem(player);

            _sb.Append("\r\n" +
                           "1. 장착 관리\r\n" +
                           "0. 나가기\r\n" +
                           "원하시는 행동을 입력해주세요.\r\n" +
                           ">> ");

            Console.Write(_sb.ToString());
        }

        public void PlayerItemEquip(Player player)
        {
            Console.Clear();
            _sb.Clear();

            _sb.Append("인벤토리 - 장착 관리\r\n" +
                            "보유 중인 아이템을 관리할 수 있습니다.\r\n" +
                            "\r\n" +
                            "[아이템 목록]\r\n");

            AppendPlayerItem(player);

            _sb.Append("\r\n" +
                            "0.나가기\r\n" +
                            "\r\n" +
                            "원하시는 행동을 입력해주세요.\r\n" +
                            ">> ");

            Console.Write(_sb.ToString());
        }

        private void AppendPlayerItem(Player player)
        {
            List<Item> playerItemList = player.Inventory.Items;
            if (playerItemList != null)
            {
                for (int i = 0; i < playerItemList.Count; i++)
                {
                    Item item= playerItemList[i];
                    if (player.Inventory.EquipItem.Contains(item))
                        _sb.AppendLine($"- {i + 1} [E] {item.Name} | {item.Stat} | {item.Description}");
                    else
                        _sb.AppendLine($"- {i + 1} {item.Name} | {item.Stat} | {item.Description}");
                }
            }
        }
    }
}
