using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Player : Character
    {
        public Player(string name, int hp, int atk) : base(name, hp, atk) { }

        public void Attack_skill(string skill)
        {
            Console.WriteLine($"{Name} uses attack skill");
        }

        public void Defense_skill(string skill)
        {
            Console.WriteLine($"{Name} uses defense skill");
        }
    }
}
