using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IWeatherResult
    {
        string Location { get; }
        IEnumerable<IMeasurement> Measurements { get; }
    }
}
