using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Monster : Character
    {
        public Monster(string name, int hp, int atk) : base(name, hp, atk) { }
    }
}
