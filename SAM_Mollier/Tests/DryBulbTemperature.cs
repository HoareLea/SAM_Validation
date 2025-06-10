namespace SAM.Mollier
{
    public sealed partial class Tests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void DryBulbTemperature(double dryBulbTemperature, double relativeHumidity, double pressure, double humidityRatio, double enthalpy)
        {
            double calculatedDryBulbTemperature = SAM.Core.Mollier.Query.DryBulbTemperature(enthalpy * 1000, humidityRatio, pressure);

            SAM.Validation.Modify.Report(dryBulbTemperature, calculatedDryBulbTemperature);
        }
    }
}
