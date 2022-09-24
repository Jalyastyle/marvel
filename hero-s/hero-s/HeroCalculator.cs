using System;
using System.Collections.Generic;
using System.Text;

namespace hero_s
{
    public class HeroCalculator<T> where T: Hero
    {
        public T MyProperty { get; set; }

        public void ForceAttack(T hero)
        {
            Console.WriteLine(hero.Name, hero.Power);
        }
    }
}
