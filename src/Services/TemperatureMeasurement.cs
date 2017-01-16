using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Common.Enums;
using Common.Interfaces;

namespace Services
{
    public class TemperatureMeasurement : IMeasurement
    {
        public TemperatureMeasurement(double value, Unit unit)
        {
            CheckParameter(unit);
            Name = "Temperature";
            Units = new List<Unit> {Unit.Celsius, Unit.Farenheit};
            SetValue(value, unit);
        }

        public string Name { get; }
        public double Value { get; private set; }
        public IEnumerable<Unit> Units { get; }
        public double ConvertTo(Unit unit)
        {
            CheckParameter(unit);
            double result = Double.NaN;

            switch (unit)
            {
                case Unit.Celsius:
                    result = Value;
                    break;

                    case Unit.Farenheit:
                    result = Converter.CelsiusToFarenheit(Value);
                    break;
            }

            return result;
        }

        private void SetValue(double value, Unit unit)
        {
            switch (unit)
            {
                case Unit.Celsius:
                    Value = value;
                    break;

                case Unit.Farenheit:
                    Value = Converter.FarenheitToCelsius(value);
                    break;
            }
        }

        private void CheckParameter (Unit unit)
        {
            if (unit != Unit.Celsius && unit != Unit.Farenheit)
                throw new ArgumentException("Invalid unit");
        }
    }
}
