namespace SAM_IAPWS
{
    [TestClass]
    public sealed partial class Tests
    {
        [TestMethod]
        public void TestMethod1()
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
