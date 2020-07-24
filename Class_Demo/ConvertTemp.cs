using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public static class ConvertTemp
    {
        public static float CelsiusToFahrenheit(float celsius)
        {
            // Convert Celsius to Fahrenheit.
            float fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public static float FahrenheitToCelsius(float fahrenheit)
        {
            // Convert Fahrenheit to Celsius.
            float celsius = (fahrenheit -32) * 5 / 9;
            return celsius;
        }
    }
}
