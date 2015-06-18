using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using MebelkiModel.Basic;
using System.Resources;
using System.Runtime.Remoting;

namespace MebelkiModel
{
    public class Board
    {
        public string Position { get; set; }

        public string FrontColor { get; set; }

        public LengthMeasure High { get; set; }
        public LengthMeasure Width { get; set; }

        public Material Material { get; set; }

        public List<Vaneer> Vaneers;

        public List<Vaneer> GetVaneers()
        {
            return new List<Vaneer>(Vaneers);
        }

        public void ClearVaneers()
        {
            Vaneers.Clear();
        }

        public void VaneersReplace(int index, Vaneer v)
        {
            var tmp = Vaneers[index];
            Vaneers[index] = v;
            if (!Vaneer.IsOnePerSide(Vaneers))
            {
                Vaneers[index] = tmp;
                throw new Exception(ModelResourceManager.GetString("OnePerSideVaneerException"));
            }
        }

        public void VaneersAdd(Vaneer v)
        {
            Vaneers.Add(v);
            try
            {
                if (!Vaneer.IsOnePerSide(Vaneers))
                {
                    Vaneers.Remove(v);
                    throw new Exception(ModelResourceManager.GetString("OnePerSideVaneerException"));
                }
            }
            catch (Exception)
            {
                Vaneers.Remove(v);
                throw;
            }
        }

        public void VaneersAddRange(IEnumerable<Vaneer> v)
        {
            Vaneers.AddRange(v);
            try
            {
                if (!Vaneer.IsOnePerSide(Vaneers))
                {
                    Vaneers.RemoveAll(v.Contains);
                    throw new Exception(ModelResourceManager.GetString("OnePerSideVaneerException"));
                }
            }
            catch (Exception)
            {
                Vaneers.RemoveAll(v.Contains);
                throw;
            }
        }

        ~Board()
        {
            Vaneers.Clear();
        }

        public Board(Board b)
        {
            Vaneers = new List<Vaneer>(b.GetVaneers());
            FrontColor = b.FrontColor;
            High = b.High;
            Material = b.Material;
            Position = b.Position;
            Width = b.Width;
        }

        public Board()
        {
            Vaneers = new List<Vaneer>();
            FrontColor = String.Empty;
            High = new LengthMeasure();
            Width = new LengthMeasure();
            Position = String.Empty;
            Material = null;
        }

        public Board(string position, string frontColor, LengthMeasure high, LengthMeasure width, Material material, List<Vaneer> vaneers)
        {
            if (vaneers.Count > 4)
            {
                throw new Exception(ModelResourceManager.GetString("OverFourVaneersException"));
            }
            Position = position;
            FrontColor = frontColor;
            High = high;
            Width = width;
            Material = material;
            Vaneers = vaneers;
        }

        public Board(string position, string frontColor, LengthMeasure high, LengthMeasure width, Material material)
        {
            Position = position;
            FrontColor = frontColor;
            High = high;
            Width = width;
            Material = material;
            Vaneers = new List<Vaneer>();
        }

        public double GetPrice()
        {
            return High.ValueMeter*Width.ValueMeter*Material?.PriceSm ?? 0;
        }

        public override string ToString()
        {
            return High + " x " + Width + " " + Material + " " + FrontColor;
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
            var s = (Board) obj;

            return FrontColor.Equals(s.FrontColor) && High.Equals(s.High) && Width.Equals(s.Width) &&
                   Material.Equals(s.Material) && Vaneers.Count == s.GetVaneers().Count &&
                   s.GetVaneers().All(v => Vaneers.Contains(v));

        }

// override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            //throw new NotImplementedException();
            return FrontColor.GetHashCode()
                   ^ High.GetHashCode()
                   ^ Width.GetHashCode()
                   ^ Material.GetHashCode()
                   ^ (Vaneers.Count > 0
                       ? Vaneers.Select(v => v.GetHashCode()).Aggregate((a, b) => a ^ b)
                       : 0);
        }

        public class BoardEqualityComparer : IEqualityComparer<Board>
        {
            public bool Equals(Board x, Board y)
            {
                return x.FrontColor.Equals(y.FrontColor) && x.High.Equals(y.High) && x.Width.Equals(y.Width) &&
                       x.Material.Equals(y.Material) && x.GetVaneers().Count == y.GetVaneers().Count &&
                       y.GetVaneers().All(v => x.GetVaneers().Contains(v));
            }

            public int GetHashCode(Board obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}