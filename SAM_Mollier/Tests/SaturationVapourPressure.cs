namespace SAM.Mollier
{
    /// Validates the calculated SaturationVapourPressure between Glueck and IAPWS.
    public sealed partial class Tests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTemperatureData), DynamicDataSourceType.Method)]
        public void SaturationVapourPressure(int temperature)
        {
            // Calculate the saturation vapour pressure using both methods
            double calculatedSaturationVapourPressure = Core.Mollier.Query.SaturationVapourPressure(temperature);
            double calculatedSaturationVapourPressure_IAPWS = Core.Mollier.Query.SaturationVapourPressure_IAPWS(temperature);
            Validation.Modify.Report(calculatedSaturationVapourPressure, calculatedSaturationVapourPressure_IAPWS);
        }

        public static IEnumerable<object[]> GetTemperatureData()
        {
            // Generate test data for temperatures from -20 to 99
            for (int i = -50; i < 100; i++)
            {
                yield return new object[] { i };
            }
        }
    }
}
