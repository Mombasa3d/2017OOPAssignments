using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2.Characters
{
    class Malboro : Character
    {
        private int hardenedFiber = 5;
        private int steelBarbs = 3;

        public Malboro() : base()
        {
            StrMod = 20;
            DexMod = 12;
            IntMod = 3;
        }

        public override int Attack()
        {   
            return this.StrBase + this.StrMod + steelBarbs;
        }

        public override int TakeDamage(int wound)
        {
            int damage = wound - hardenedFiber;
            this.CurrentHP -= damage;
            return damage;
        }   
    }
}
