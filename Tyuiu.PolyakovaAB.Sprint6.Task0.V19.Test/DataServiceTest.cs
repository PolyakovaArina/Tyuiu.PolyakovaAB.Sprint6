using Tyuiu.PolyakovaAB.Sprint6.Task0.V19.Lib;
namespace Tyuiu.PolyakovaAB.Sprint6.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            Assert.AreEqual(-1, ds.Calculate(x));
        }
    }
}
