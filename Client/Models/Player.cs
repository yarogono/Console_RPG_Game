using Client.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string CharacterClass { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Hp { get; set; }
        public int Gold { get; set; }

        public Inventory Inventory { get; set; }

        public Define.GameScene Scene { get; set; }

        public Player(string name, int level, string characterClass, int attack, int defense, int hp, int gold, Define.GameScene scene = Define.GameScene.Town)
        {
            Name = name;
            Level = level;
            CharacterClass = characterClass;
            Attack = attack;
            Defense = defense;
            Hp = hp;
            Gold = gold;
            Scene = scene;
        }
    }
}
