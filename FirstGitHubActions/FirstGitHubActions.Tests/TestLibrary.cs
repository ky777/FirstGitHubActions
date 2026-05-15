namespace FirstGitHubActions.Tests
{
    [TestClass]
    public sealed class TestLibrary
    {
        [TestMethod]
        public void TestMethod_OS()
        {
            //Assert.IsTrue(FirstGitHubActions.Library.Info.GetOS() == Environment.OSVersion.ToString());
            Assert.AreEqual(FirstGitHubActions.Library.Info.GetOS(), Environment.OSVersion.ToString());
        }
    }
}
