﻿using System;
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
    }
}
