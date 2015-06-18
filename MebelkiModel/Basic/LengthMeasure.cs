using System;
using System.Threading;
using MebelkiModel.Basic.Enums;

namespace MebelkiModel.Basic
{
    [Serializable]
    public class LengthMeasure
    {
        private double _value;

        public double Value
        {
            get { return _value/Math.Pow(10, (int) Unit); }
            set { _value = value*Math.Pow(10, (int) Unit); }
        }

        public double ValueMeter
        {
            get { return _value; }
            set { _value = value; }
        }


        public LengthUnit Unit { get; set; }

        public string UnitName => Unit.ToString();

        public LengthMeasure()
        {
            _value = 0;
            Unit = LengthUnit.mm;
        }

        public LengthMeasure(double val)
        {
            _value = val;
            Unit = LengthUnit.mm;
        }

        public LengthMeasure(double val, LengthUnit u)
        {
            _value = val * Math.Pow(10,(int) u);
            Unit = u;
        }

        public override string ToString()
        {
            return Value.ToString(Thread.CurrentThread.CurrentCulture) + UnitName;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var v = (LengthMeasure) obj;
            return Equals(_value, v._value);

        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}