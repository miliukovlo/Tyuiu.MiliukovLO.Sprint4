using Tyuiu.MiliukovLO.Sprint4.Task6.V20.Lib;

namespace Tyuiu.MiliukovLO.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string[] test = new string[] {"����������", "������", "�����", "��������", "���������", "�������", "����������"};
            Assert.AreEqual(["������", "�����", "��������", "���������", "�������"],ds.Calculate(test));
        }
    }
}