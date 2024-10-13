using Tyuiu.MiliukovLO.Sprint4.Task5.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new();
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                                ");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              ");
        Console.WriteLine("* Задание #5                                                               ");
        Console.WriteLine("* Вариант #9                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         ");
        Console.WriteLine("* случайными значениями в диапазоне от -4 до 4. Найти количество           ");
        Console.WriteLine("* положительных элементов                                                  ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = new int[5, 5];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(-4, 4);
            }
        }
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(matrix));
    }
}