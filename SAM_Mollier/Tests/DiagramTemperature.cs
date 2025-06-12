namespace SAM.Mollier
{
    /// Validates the calculated SaturationVapourPressure between Glueck and IAPWS.
    public sealed partial class Tests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetHumidityRatioData), DynamicDataSourceType.Method)]
        public void DiagramTemperature(double humidityRatio)
        {
            // Calculate the saturation vapour pressure using both methods
            double calculatedDiagramTemperature = Core.Mollier.Query.DiagramTemperature(0, humidityRatio / 1000, 101325);
            double calculatedDiagramTemperature_WIP = Core.Mollier.Query_WIP.DiagramTemperature(0, humidityRatio / 1000, 101325);
            Validation.Modify.Report_AbsoluteError(calculatedDiagramTemperature, calculatedDiagramTemperature_WIP, 0.1);
        }

        public static IEnumerable<object[]> GetHumidityRatioData()
        {
            // Generate test data for temperatures from -20 to 99
            for (int i = 14; i < 15; i++)
            {
                yield return new object[] { Convert.ToDouble(i) };
            }
        }
    }
}
