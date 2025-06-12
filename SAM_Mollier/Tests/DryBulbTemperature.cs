namespace SAM.Mollier
{
    public sealed partial class Tests
    {
        /// <summary>
        /// Tests the calculation of the dry bulb temperature based on enthalpy, humidity ratio, and pressure.
        /// </summary>
        /// <param name="dryBulbTemperature">The expected dry bulb temperature in degrees Celsius.</param>
        /// <param name="relativeHumidity">The relative humidity as a percentage.</param>
        /// <param name="pressure">The atmospheric pressure in Pascals.</param>
        /// <param name="humidityRatio">The humidity ratio (mass of water vapor per mass of dry air).</param>
        /// <param name="enthalpy">The specific enthalpy in kJ/kg.</param>
        /// <remarks>
        /// This test verifies that the calculated dry bulb temperature matches the expected value
        /// by using the provided enthalpy, humidity ratio, and pressure as inputs.
        /// </remarks>
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void DryBulbTemperature(double dryBulbTemperature, double relativeHumidity, double pressure, double humidityRatio, double enthalpy)
        {
            double calculatedDryBulbTemperature = SAM.Core.Mollier.Query.DryBulbTemperature(enthalpy * 1000, humidityRatio, pressure);

            SAM.Validation.Modify.Report_RelativeError(dryBulbTemperature, calculatedDryBulbTemperature);
        }
    }
}
