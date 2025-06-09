using Xunit;
using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using SAM.Core.Mollier.Query; // Corrected method reference

namespace SAM.Mollier.Tests
{
    public class HumidityRatioTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void ValidateHumidityRatioAgainstReference(double t, double rh, double pressure, double expectedX)
        {
            // rh must be given as fraction (0-1)
            double actualX = HumidityRatio.HumidityRatio(t, rh / 100.0, pressure);
            Assert.True(Math.Abs(actualX - expectedX) < 0.0005, $"Expected {expectedX}, got {actualX} at T={t}, RH={rh}%");
        }

        public static IEnumerable<object[]> GetTestData()
        {
            var path = Path.Combine("reference", "psychrolib_validation.csv");
            var lines = File.ReadAllLines(path);
            foreach (var line in lines.Skip(1)) // skip header
            {
                var parts = line.Split(',');
                yield return new object[]
                {
                    double.Parse(parts[0], CultureInfo.InvariantCulture), // T [°C]
                    double.Parse(parts[1], CultureInfo.InvariantCulture), // RH [%]
                    double.Parse(parts[2], CultureInfo.InvariantCulture), // Pressure [Pa]
                    double.Parse(parts[3], CultureInfo.InvariantCulture)  // Expected x [kg/kg]
                };
            }
        }
    }
}
