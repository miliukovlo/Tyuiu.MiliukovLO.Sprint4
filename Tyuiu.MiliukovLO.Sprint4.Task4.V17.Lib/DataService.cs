﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MiliukovLO.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            int result = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        result += matrix[i, j];
                    }
                }
            }
            return result;
        }
    }
}
