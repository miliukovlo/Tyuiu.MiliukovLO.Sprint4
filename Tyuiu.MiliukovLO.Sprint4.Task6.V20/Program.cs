using Tyuiu.MiliukovLO.Sprint4.Task6.V20.Lib;

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
        string[] test = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        string[] arr = ds.Calculate(test) as string[];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}