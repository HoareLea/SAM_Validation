using System.Globalization;

namespace SAM_Mollier
{
    /// <summary>
    /// Contains unit tests for verifying the functionality of the SAM.Core.Mollier.Query methods.
    /// </summary>
    [TestClass]
    public sealed partial class Tests
    {
        private static readonly string path = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppContext.BaseDirectory))), "validation_data", "psychrolib_validation.csv");

        // Method to provide data for the test
        public static IEnumerable<object[]> GetTestData()
        {
            if(!Path.Exists(path))
            {
                return Enumerable.Empty<object[]>();
            }

            List<object[]> result = new List<object[]>();
            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("t"))
                    continue;

                var parts = line.Split(',');

                if (parts.Length < 5)
                    continue;

                if (double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double dryBulbTemperature) &&
                    double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double relativeHumidity) &&
                    double.TryParse(parts[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double pressure) &&
                    double.TryParse(parts[3], NumberStyles.Float, CultureInfo.InvariantCulture, out double humidityRatio) &&
                    double.TryParse(parts[4], NumberStyles.Float, CultureInfo.InvariantCulture, out double enthalpy))
                {
                    result.Add([dryBulbTemperature, relativeHumidity, pressure, humidityRatio, enthalpy]);
                }
            }

            return result;
        }
    }
}
