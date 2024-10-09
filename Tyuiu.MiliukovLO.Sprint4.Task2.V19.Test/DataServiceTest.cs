using Tyuiu.MiliukovLO.Sprint4.Task2.V19.Lib;

namespace Tyuiu.MiliukovLO.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new();
            int[] array = new int[] { 1, 2, 3 };
            Assert.AreEqual(4, dataService.Calculate(array));
        }
    }
}