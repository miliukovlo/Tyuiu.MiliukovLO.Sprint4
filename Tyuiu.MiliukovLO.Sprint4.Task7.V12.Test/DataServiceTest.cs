using Tyuiu.MiliukovLO.Sprint4.Task7.V12.Lib;

namespace Tyuiu.MiliukovLO.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string test = "658932125478";
            Assert.AreEqual(33, ds.Calculate(3,4,test));
        }
    }
}