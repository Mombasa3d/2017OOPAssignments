    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2.Characters
{
    public abstract class Character
    {
        //Attributes
        protected string name;
        protected int strBase;
        protected int intBase;
        protected int dexBase;

        protected int strMod = 0;
        protected int intMod = 0;
        protected int dexMod = 0;

        protected int baseHP;
        protected int currentHP;

        protected Weapon charWep;
        protected Armor charArmor;

        protected Random statRando = new Random();

        //Properties
        public string Name { get; set; }
        public int StrBase { get; set; }
        public int IntBase { get; set; }
        public int DexBase { get; set; }
        public int StrMod { get; set; }
        public int IntMod { get; set; }
        public int DexMod { get; set; }
        public int Strength => strBase + strMod;
        public int Dexterity => dexBase + dexMod;
        public int Intelligence => intBase + intMod;
        public int BaseHP { get => baseHP; }
        public int CurrentHP { get => currentHP; set => currentHP = value; }
        public Weapon CharWep { get => charWep; set => charWep = value; }

        //Constructors

        public Character()
        {
            this.baseHP = strBase * 10;
            StrBase = statRando.Next(3, 31);
            IntBase = statRando.Next(3, 31);
            DexBase = statRando.Next(3, 31);
            StrMod = 0;
            IntMod = 0;
            DexMod = 0;
            CurrentHP = BaseHP;
        }

        //Methods

        public abstract int Attack();
        public abstract int TakeDamage(int wound);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           // sb.Append();
            return sb.ToString();
        }

    }
}
