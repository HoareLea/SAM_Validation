namespace SAM.Mollier
{

    public sealed partial class Tests
    {
        /// <summary>
        /// Tests the HumidityRatio calculation method by comparing the calculated value
        /// against the expected value for given input parameters.
        /// </summary>
        /// <param name="dryBulbTemperature">The dry bulb temperature in degrees Celsius.</param>
        /// <param name="relativeHumidity">The relative humidity as a percentage (0-100).</param>
        /// <param name="pressure">The atmospheric pressure in Pascals.</param>
        /// <param name="humidityRatio">The expected humidity ratio value.</param>
        /// <param name="enthalpy">The expected enthalpy value (not used in this test).</param>
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void HumidityRatio(double dryBulbTemperature, double relativeHumidity, double pressure, double humidityRatio, double enthalpy)
        {
            // Calculate the humidity ratio using the SAM.Core.Mollier.Query method.
            double calculatedHumidityRatio = SAM.Core.Mollier.Query.HumidityRatio(dryBulbTemperature, relativeHumidity, pressure);

            // Report the comparison between the expected and calculated humidity ratio values.
            SAM.Validation.Modify.Report(humidityRatio, calculatedHumidityRatio);
        }
    }
}
