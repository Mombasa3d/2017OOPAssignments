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
        protected int damageReduction = 0;
        protected Random statRando = new Random();

        //Properties
        public string Name { get => name; set => name = (string.IsNullOrEmpty(value) ? "Default" : value); }
        public int StrBase { get; set; }
        public int IntBase { get; set; }
        public int DexBase { get; set; }
        public int StrMod { get => strMod; set => strMod = value; }
        public int IntMod { get => intMod; set => intMod = value; }
        public int DexMod { get => dexMod; set => dexMod = value; }
        public int Strength { get => StrBase + StrMod; }
        public int Dexterity { get => DexBase + DexMod - CharArmor.AgilityModifier; }
        public int Intelligence { get => IntBase + IntMod; }
        public int BaseHP { get => baseHP; set => baseHP = (value <= 0) ? 10 : value; }
        public int CurrentHP { get => currentHP; set => currentHP = (currentHP + value > BaseHP) ? BaseHP  : currentHP + value; }
        public Weapon CharWep { get => charWep; set => charWep = value; }
        public Armor CharArmor { get => charArmor; set => charArmor = value; }
        public int DamageReduction { get; set; }
        //Constructors

        public Character()
        {
            BaseHP = strBase * 10;
            StrBase = statRando.Next(3, 31);
            IntBase = statRando.Next(3, 31);
            DexBase = statRando.Next(3, 31);
            StrMod = 0;
            IntMod = 0;
            DexMod = 0;
            CurrentHP = BaseHP;
            CharWep = new Weapon();
            CharArmor = new Armor();
            DamageReduction = CharArmor.DamageReduction;
        }

        //Methods

        public abstract int Attack();
        public abstract int TakeDamage(int wound);



    }
}
