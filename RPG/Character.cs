using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Character
    {
        public int hp;
        public int mp;
        public int dmg;
        public Character target;
        public void attack()
        {
            target.hp -= dmg; 
        }
    }
}
