using Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Stat { get; set; }
        public Define.ItemType Type { get; set; }
        public string Description { get; set; }

        public Item(int itemId, string name, string stat, Define.ItemType type, string description)
        {
            ItemId = itemId;
            Name = name;
            Stat = stat;
            Type = type;
            Description = description;
        }
    }
}
