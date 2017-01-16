using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Enums;
using Common.Interfaces;

namespace Services.AccuWeatherService
{
    public class AccuWeatherServiceResult : IWeatherResult
    {
        public AccuWeatherServiceResult(string location, double windSpeedMph, double tempF)
        {
            Location = location;
            CreateMeasurements(windSpeedMph, tempF);
        }

        public string Location { get; }

        public IEnumerable<IMeasurement> Measurements { get; private set; }

        private void CreateMeasurements (double windSpeedMph, double tempF)
        {
            Measurements = new List<IMeasurement>()
            {
                new WindSpeedMeasurement(windSpeedMph, Unit.Mph),
                new TemperatureMeasurement(tempF, Unit.Farenheit),
            };
        }
    }
}
