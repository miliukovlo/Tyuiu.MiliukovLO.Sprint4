using Tyuiu.MiliukovLO.Sprint4.Task5.V9.Lib;

namespace Tyuiu.MiliukovLO.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] test = new int[5, 5] { { 2, 3, 2, 4, 3 }, { 4, 7, 4, 2, 2 }, { 5, 2, 3, 4, 6 }, { 5, 2, 7, 6, 5 }, { 6, 3, 5, 7, 7 } };
            Assert.AreEqual(25, ds.Calculate(test));
        }
    }
}