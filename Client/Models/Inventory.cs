using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Inventory
    {
        public List<Item> EquipItem { get; set; } = new List<Item>();
        public List<Item> Items { get; set; } = new List<Item>();

        public Inventory()
        {
        }

        public Inventory(List<Item> equipItem, List<Item> items)
        {
            EquipItem = equipItem;
            Items = items;
        }
    }
}
