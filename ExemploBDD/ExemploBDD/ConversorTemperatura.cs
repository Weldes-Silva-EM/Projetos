using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExemploBDD
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(double temperatura)
        {
            return Math.Round((temperatura - 32) / 1.8, 2);
        }
        public static double FahrenheitParaKelvin(double temperatura)
        {
            return Math.Round((temperatura - 32) / 1.8, 2) + 273.15;

        }

    }
}
