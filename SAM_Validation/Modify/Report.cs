namespace SAM.Validation
{
    public static partial class Modify
    {
        public static void Report_RelativeError(double value, double calculatedValue, double relativeError = Error.Relative, double tolerance = Core.Tolerance.Distance)
        {
            double calculatedRelativeError = value == 0 ? Math.Abs(calculatedValue - value) : (Math.Abs(calculatedValue - value) / value); 

            Assert.IsTrue(calculatedRelativeError <= relativeError, string.Format("[Value: {0}] [Calculated value: {1}] [Max Relative Error: {2}%] [Calculated Relative Error: {3}%] ", value, calculatedValue, Core.Query.Round(relativeError, tolerance) * 100, Core.Query.Round(calculatedRelativeError, tolerance) * 100));
        }

        public static void Report_AbsoluteError(double value, double calculatedValue, double error, double tolerance = Core.Tolerance.Distance)
        {
            double calculatedError = Math.Abs(calculatedValue - value);

            Assert.IsTrue(calculatedError <= error, string.Format("[Value: {0}] [Calculated value: {1}] [Max Relative Error: {2}%] [Calculated Relative Error: {3}%] ", value, calculatedValue, Core.Query.Round(error, tolerance), Core.Query.Round(calculatedError, tolerance)));
        }
    }
}
