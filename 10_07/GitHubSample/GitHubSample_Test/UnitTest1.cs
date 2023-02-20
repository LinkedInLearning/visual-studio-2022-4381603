using GitHubSample;

namespace GitHubSample_Test
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sample sample = new Sample();
            Assert.AreEqual(sample.AddMethod(2, 5), 7);
        }
    }
}