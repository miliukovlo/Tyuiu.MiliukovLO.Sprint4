using tyuiu.cources.programming.interfaces.Sprint4;
using System.Collections.Generic;

namespace Tyuiu.MiliukovLO.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < array.Length; i++) // Изменено на < вместо <=
            {
                if (array[i].Length < 10)
                {
                    result.Add(array[i]); // Используем Add для добавления элемента в список
                }
            }

            return result.ToArray(); // Преобразуем список обратно в массив
        }
    }
}
