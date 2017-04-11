using RustShaker.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RustShaker.Models

{
    class Bear
    {
        public string FurColor { get; set; }
        private string Name { get; set; }
        private float WeightInKilos { get; set; }
        private int AgeInYears { get; set; }
        private readonly BearType flavor;

        //Properties
        public BearType Flavor { get { return flavor; } }

        //Constructors
        public Bear(string color, string name, float weight, int age, BearType flav)
        {
            Name = name;
            FurColor = color;
            WeightInKilos = weight;
            AgeInYears = age;
            this.flavor = flav;

        }


        public Bear()
        {
            Name = "Burr";
            FurColor = "Red ";
            WeightInKilos = 236.5F;
            AgeInYears = 15;
            this.flavor = BearType.Lava;
        }

        public override string ToString()
        {
            return "== Bear ==\n" + "Name: " + Name + "\nFur Color: " + FurColor + "\nWeight (kg): " + WeightInKilos + "\nAge: " + AgeInYears +
                "\nFlavor: " + flavor.ToString() + "\n";
        }
    }
}
