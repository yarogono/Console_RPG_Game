using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    public class InventoryController
    {
        public static void EquipItem(Player player, Item item)
        {
            if (player == null || item == null)
                return;

            player.Inventory.EquipItem.Add(item);
        }

        public static void UnEquipItem(Player player, Item item)
        {
            if (player == null || item == null)
                return;

            player.Inventory.EquipItem.Remove(item);
        }
    }
}
