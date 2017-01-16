using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Enums;

namespace Services.BbcWeatherService
{
    public class BbcWeatherServiceResult : IWeatherResult
    {
        public BbcWeatherServiceResult(string location, double windSpeedKph, double tempC)
        {
            Location = location;
            CreateMeasurements(windSpeedKph, tempC);
        }

        public string Location { get; }
        public IEnumerable<IMeasurement> Measurements { get; private set; }

        private void CreateMeasurements (double windSpeedKph, double tempC)
        {
            Measurements = new List<IMeasurement>()
            {
                new WindSpeedMeasurement(windSpeedKph, Unit.Kph),
                new TemperatureMeasurement(tempC, Unit.Celsius),
            };
        }
    }
}
