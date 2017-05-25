using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2.Characters
{
    class Monk : Character
    {

        public Monk()
        {
            this.Name = "Monk";
            this.strBase = 25;
            this.strMod = 7;
            this.dexBase = 10;
            this.dexMod = 5;
            this.intBase = 2;
            this.intMod = -4;
            this.CurrentHP = baseHP;
        }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override int TakeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
