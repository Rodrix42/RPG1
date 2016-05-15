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
                target.Hp = (int)(target.Hp + 50);
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
