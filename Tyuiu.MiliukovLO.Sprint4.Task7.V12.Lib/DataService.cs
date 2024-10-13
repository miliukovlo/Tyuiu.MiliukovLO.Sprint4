using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MiliukovLO.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[i*3+j].ToString());
                    if (matrix[i, j] % 2 == 1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
