using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace LootGenV2.Characters
{
    class Monk : Character
    {

        public Monk()
        {
            Name = "Monk";
            StrBase = 25;
            StrMod = 7;
            DexBase = 10;
            DexMod = 5;
            IntBase = 2;
            IntMod = -4;
            CurrentHP = baseHP;
            CharWep = new Weapon();
            CharArmor = new Armor();
        }

        public override int Attack()
        {
            return this.StrBase + StrMod;
        }

        public override int TakeDamage(int wound)
        {
            CurrentHP -= wound;
            return wound;
        }
    }
}
