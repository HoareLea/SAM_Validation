namespace SAM.Mollier
{
    public sealed partial class Tests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Enthalpy(double dryBulbTemperature, double relativeHumidity, double pressure, double humidityRatio, double enthalpy)
        {
            double calculatedEnthalpy = Core.Mollier.Query.Enthalpy(dryBulbTemperature, humidityRatio, pressure) / 1000;

            Validation.Modify.Report(enthalpy, calculatedEnthalpy);
        }
    }
}
