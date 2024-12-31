using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }

        public Character(string name, int hp, int atk)
        {
            Name = name;
            HP = hp;
            ATK = atk;
        }

        public virtual void Attack(Character target)
        {
            Console.WriteLine($"{Name} attacks {target.Name}!");
            target.HP -= ATK;
        }
    }
}

