using Tyuiu.MiliukovLO.Sprint4.Task0.V4.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                                ");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                              ");
        Console.WriteLine("* Задание #0                                                               ");
        Console.WriteLine("* Вариант #2                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный          ");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение    ");
        Console.WriteLine("* четных элементов массива.  {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}                ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        int[] array = new int[] { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
        Console.WriteLine(ds.GetMultEvenArrEl(array));
        Console.ReadKey();
    }
}