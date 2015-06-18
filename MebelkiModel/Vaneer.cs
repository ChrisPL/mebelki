using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using MebelkiModel.Basic;
using MebelkiModel.Basic.Enums;

namespace MebelkiModel
{
    public class Vaneer
    {
        public Side Side { get; set; }

        public double Length { get; set; }

        /// <summary>
        /// PriceSm per linear meter
        /// </summary>
        public double PriceLm { get; set; }
    

        public Vaneer()
        {
            Side = Side.Height1;
            Length = 0;
            PriceLm = 0;
        }

        public Vaneer(Side side, double length, double priceLm = 0)
        {
            Side = side;
            Length = length;
            PriceLm = priceLm;
        }

        public Vaneer(Side side, Board board, double priceLm = 0)
        {
            Side = side;
            PriceLm = priceLm;
            switch (side)
            {
                case Side.Height1:
                case Side.Height2:
                    Length = board.High.ValueMeter;
                    break;
                case Side.Width1:
                case Side.Width2:
                    Length = board.Width.ValueMeter;
                    break;
            }
        }

        public Vaneer(Vaneer v)
        {
            Side = v.Side;
            Length = v.Length;
            PriceLm = v.PriceLm;
        }

        public double GetTotalPrice()
        {
            return Length*PriceLm;
        }

        public static bool IsOnePerSide(List<Vaneer> list)
        {
            if (list.Count > 4)
            {
                throw new Exception(ModelResourceManager.GetString("OverFourVaneersException"));
            }
            return !list.Any(s => list.Where(s2 => !Equals(s2, s)).Any(s2 => s2.Side == s.Side));
        }

        public override string ToString()
        {
            return ModelResourceManager.GetString(Side.ToString()) + " " + GetTotalPrice() + " " + ModelResourceManager.GetString("Currency");
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var v = (Vaneer) obj;

            return Side == v.Side && Length.Equals(v.Length) && PriceLm.Equals(v.PriceLm);

        }

// override object.GetHashCode
        public override int GetHashCode()
        {
            return Length.GetHashCode()
                   ^ PriceLm.GetHashCode()
                   ^ Side.GetHashCode();
        }
    }
}