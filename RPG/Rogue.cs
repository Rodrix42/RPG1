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
            
            this.Hp = hp;
            this.Mp = mp;
            this.Dmg = dmg;
        }
        
        public override void Skill1()
        {
            if (this.Mp < 50)
            {

            }
            else
            {
                target.Dmg = (int)(target.Dmg + target.Dmg * 0.5);
                this.Mp = this.Mp - 50;
            }
        }
    }
}
