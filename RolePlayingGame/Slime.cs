using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Slime : Monster
    {
        public Slime(string name, int hp, int atk) : base(name, hp, atk) { }

        public void BounceAttack()
        {
            Console.WriteLine($"{Name} uses Bounce Attack!");
        }
    }
}
