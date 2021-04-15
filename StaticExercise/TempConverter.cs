using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static void FahrenheitToCelsius(double ftc)
        {
            var fahrenheit = (ftc - 32) * .5556;
            Console.WriteLine(fahrenheit);
        }
        public static void CelsiusToFahrenheit(double ctf)
        {
            var celcius = (ctf * 1.8) + 32;
            Console.WriteLine(celcius);
        }


    }
}
