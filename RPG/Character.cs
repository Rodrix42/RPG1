using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Character
    {
        private int hp;

        public int Hp
        {
            get { return hp; }
            set {
                if (value < 0)
                {
                    hp = 0;
                }
                else
                    hp = value;
                }
        }
        private int mp;

        public int Mp
        {
            get { return mp; }
            set {
                if (value < 0)
                {
                    mp = 0;
                }
                else
                    mp = value;
                }
        }
        private int dmg;

        public int Dmg
        {
            get { return dmg; }
            set
            {
                if (value < 0)
                {
                    dmg = 0;
                }
                else
                    dmg = value;
            }
        }
        public Character target;
        public void attack()
        {
            target.hp -= dmg; 
        }
    }
}
