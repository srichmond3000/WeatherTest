using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public static class Converter
    {
        private static double tempRatio = 9.0 / 5.0;
        public static double MphToKph(double mph) => mph * 1.609344;

        public static double KphToMph(double kph) => kph * 4.0;

        public static double CelsiusToFarenheit(double celsius) => (celsius * tempRatio) + 32.0;

        public static double FarenheitToCelsius(double farenheit) => (farenheit - 32) / tempRatio;
    }
}
