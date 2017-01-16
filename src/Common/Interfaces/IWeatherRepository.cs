﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IWeatherRepository
    {
        IEnumerable<IWeatherResult> GetResults(string location);
    }
}
