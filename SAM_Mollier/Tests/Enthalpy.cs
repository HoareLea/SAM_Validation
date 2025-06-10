namespace SAM.Mollier
{
    public sealed partial class Tests
    {
        /// <summary>
        /// Validates the calculated enthalpy against the expected enthalpy value.
        /// </summary>
        /// <param name="dryBulbTemperature">The dry bulb temperature in degrees Celsius.</param>
        /// <param name="relativeHumidity">The relative humidity as a percentage.</param>
        /// <param name="pressure">The atmospheric pressure in Pascals.</param>
        /// <param name="humidityRatio">The humidity ratio (mass of water vapor per mass of dry air).</param>
        /// <param name="enthalpy">The expected enthalpy value in kJ/kg.</param>
        /// <remarks>
        /// This test method uses dynamic data to validate the enthalpy calculation
        /// performed by the Core.Mollier.Query.Enthalpy method. The calculated enthalpy
        /// is compared to the expected value, and any discrepancies are reported.
        /// </remarks>
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Enthalpy(double dryBulbTemperature, double relativeHumidity, double pressure, double humidityRatio, double enthalpy)
        {
            double calculatedEnthalpy = Core.Mollier.Query.Enthalpy(dryBulbTemperature, humidityRatio, pressure) / 1000;

            Validation.Modify.Report(enthalpy, calculatedEnthalpy);
        }
    }
}
