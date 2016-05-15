using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Palladin : Character
    {
        public Palladin(int hp, int mp, int dmg)
        {
            this.Hp = hp;
            this.Mp = mp;
            this.Dmg = dmg;
        }
        public override void Skill1()
        {
            if (this.Mp < 60)
            {

            }
            else
            {
                target.Dmg = (int)(target.Dmg - target.Dmg * 0.1);
                this.Mp = this.Mp - 60;
            }
        }
        public override void Skill2(List<Character> Targets)
        {
            if (this.Mp < 50)
            {

            }
            else
            {
 
            }
        }
    }
}