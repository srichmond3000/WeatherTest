using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Enums;

namespace Common.Interfaces
{
    public interface IMeasurement
    {
        string Name { get; }
        double Value { get; }
        IEnumerable<Unit> Units { get; }
        double ConvertTo(Unit unit);
    }
}
