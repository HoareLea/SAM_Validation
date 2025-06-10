namespace SAM.Validation
{
    public sealed partial class Tests
    {
        [DataTestMethod]
        public void Test()
        {
            int a = 5;
            int b = 10;
            int expected = 15;

            // Act: Call the method under test
            int actual = a + b;

            // Assert: Verify the result
            Assert.AreEqual(expected, actual, "The Add method did not return the correct sum.");
        }
    }
}
