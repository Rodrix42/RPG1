using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Priest : Character
    {
        public Priest(int hp, int mp, int dmg)
        {
            this.hp = hp;
            this.mp = mp;
            this.dmg = dmg;
        }
    }
}
