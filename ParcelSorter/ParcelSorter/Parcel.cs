using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelSorter
{
    class Parcel : IComparable<Parcel>
    {
        private static Random rando = new Random();
        private readonly float ParcelHeight;
        private readonly float ParcelWidth;
        private readonly float parcelDepth;
        private readonly float parcelID = rando.Next(5000000);
        private float WeightPerCubicInch { get; set; }
        private float ParcelWeight { set; get; }

        public Parcel(float weight, float height, float width, float depth)
        {
            this.ParcelHeight = height;
            this.ParcelWidth = width;
            this.parcelDepth = depth;
            ParcelWeight = weight;
            WeightPerCubicInch = (width * height * depth) / (weight);


        }

        public int CompareTo(Parcel other)
        {
            if(this.WeightPerCubicInch < other.WeightPerCubicInch)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            StringBuilder parcelSB = new StringBuilder();
            parcelSB.Append("=== | Parcel ID: " + this.parcelID + "\n");
            parcelSB.Append("Height: " + this.ParcelHeight + "\n");
            parcelSB.Append("Width: " + this.ParcelWeight + "\n");
            parcelSB.Append("Depth: " + this.parcelDepth + "\n");
            parcelSB.Append("Weight: " + this.ParcelWeight + "\n");
            parcelSB.Append("Pounds per Cubic In. :" + this.WeightPerCubicInch + "\n");
            return parcelSB.ToString();
        }
    }
}
