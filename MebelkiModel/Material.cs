using System.CodeDom;
using MebelkiModel.Basic;

namespace MebelkiModel
{
    public class Material
    {
        public string Name { get; set; }
        public LengthMeasure Thick { get; set; }
        /// <summary>
        /// Price per squared meter
        /// </summary>
        public double PriceSm { get; set; }

        public Material()
        {
            
        }

        public Material(string name, LengthMeasure thick, double priceSm)
        {
            Name = name;
            Thick = thick;
            PriceSm = priceSm;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Material m = (Material) obj;
            return this.Name.Equals(m.Name) && Equals(PriceSm,m.PriceSm) && this.Thick.Equals(m.Thick);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode()
                   ^ PriceSm.GetHashCode()
                   ^ Thick.GetHashCode();
        }
    }
}