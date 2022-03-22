using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_10.Setter_init_uniquement
{
    internal class csharp_9
    {
        public struct WeatherObservation
        {
            public DateTime RecordedAt { get; init; }
            public decimal TemperatureInCelsius { get; init; }
            public decimal PressureInMillibars { get; init; }

            public override string ToString() =>
                $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
                $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
        }
        public static void Main()
        {
            var now = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };
            List<WeatherObservation> _observations = new();
        }
    }
}
