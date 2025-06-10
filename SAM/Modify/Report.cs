namespace SAM.Validation
{
    public static partial class Modify
    {
        public static void Report(double value, double calculatedValue, double relativeError = Error.Relative, double tolerance = Core.Tolerance.Distance)
        {
            double calculatedRelativeError = value == 0 ? Math.Abs(calculatedValue - value) : (Math.Abs(calculatedValue - value) / value);

            calculatedRelativeError = Core.Query.Round(calculatedRelativeError); 

            Assert.IsTrue(calculatedRelativeError <= relativeError, string.Format("[Value: {0}] [Calculated value: {1}] [Max Relative Error: {2}%] [Calculated Relative Error: {3}%] ", value, calculatedValue, Core.Query.Round(relativeError, tolerance) * 100, Core.Query.Round(calculatedRelativeError, tolerance) * 100));
        }
    }
}
