using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Rogue : Character
    {
        public Rogue(int hp, int mp, int dmg)
        {
            this.hp = hp;
            this.mp = mp;
            this.dmg = dmg;
        }
    }
}
