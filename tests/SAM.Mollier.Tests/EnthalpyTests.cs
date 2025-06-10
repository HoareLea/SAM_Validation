using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Xunit;

namespace SAM.Mollier.Tests
{
    public class EnthalpyTests
    {
        // Adjust the path to your CSV file as needed
        private static readonly string CsvFilePath = Path.Combine(AppContext.BaseDirectory, "reference", "psychrolib_validation.csv");

        public static IEnumerable<object[]> GetTestData()
        {
            foreach (var line in File.ReadAllLines(CsvFilePath))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("t"))
                    continue;

                var parts = line.Split(',');

                if (parts.Length < 5)
                    continue;

                if (double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double t) &&
                    double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double rh) &&
                    double.TryParse(parts[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double pressure) &&
                    double.TryParse(parts[3], NumberStyles.Float, CultureInfo.InvariantCulture, out double x) &&
                    double.TryParse(parts[4], NumberStyles.Float, CultureInfo.InvariantCulture, out double expectedH))
                {
                    yield return new object[] { t, rh, pressure, x, expectedH };
                }
            }
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void ValidateEnthalpyAgainstReference(double t, double rh, double pressure, double x, double expectedH)
        {
            double actualH = SAM.Core.Mollier.Query.Enthalpy(t, x, pressure);

            // Optional: Uncomment the following line for debugging purposes
            // Console.WriteLine($"T={t}, RH={rh}%, Pressure={pressure} Pa, X={x}, Expected H={expectedH}, Actual H={actualH}");

            Assert.InRange(actualH, expectedH - 0.05, expectedH + 0.05);
        }
    }
}
