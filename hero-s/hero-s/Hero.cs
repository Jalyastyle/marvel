using System;
using System.Collections.Generic;
using System.Text;

namespace hero_s
{
    public class Hero
    {
        public string Name { get; set; }
        public string Power { get; set; }

        public Hero(string name, string power)
        {
            Name = name;
            Power = power;
        }
    }
   


}
