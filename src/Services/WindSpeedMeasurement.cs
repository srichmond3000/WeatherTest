using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Enums;
using Common.Interfaces;

namespace Services
{
    public class WindSpeedMeasurement : IMeasurement
    {
        public WindSpeedMeasurement(double value, Unit unit)
        {
            CheckParameter(unit);

            Units = new List<Unit>() {Unit.Mph, Unit.Kph};
            Name = "Wind Speed";
            SetValue(value, unit);
        }

        public string Name { get; }

        public double Value { get; private set; }

        public IEnumerable<Unit> Units { get; }

        public double ConvertTo (Unit unit)
        {
            CheckParameter(unit);
            double result = Double.NaN;

            switch (unit)
            {
                case Unit.Kph:
                    result = Value;
                    break;

                case Unit.Mph:
                    result = Converter.KphToMph(Value);
                    break;
            }

            return result;
        }

        private void SetValue (double value, Unit unit)
        {
            switch (unit)
            {
                case Unit.Kph:
                    Value = value;
                    break;

                case Unit.Mph:
                    Value = Converter.MphToKph(value);
                    break;
            }
        }

        private void CheckParameter(Unit unit)
        {
            if (unit != Unit.Kph && unit != Unit.Mph)
                throw new ArgumentException("Invalid unit");
        }
    }
}
