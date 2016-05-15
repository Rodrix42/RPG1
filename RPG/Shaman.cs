using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Shaman : Character
    {
        public Shaman(int hp, int mp, int dmg)
        {
            this.Hp = hp;
            this.Mp = mp;
            this.Dmg = dmg;
        }
        public override void Skill1()
        {
            if (this.Mp < 40)
            {

            }
            else
            {
                target.Mp = (int)(target.Mp + 60);
                this.Mp = this.Mp - 40;
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
