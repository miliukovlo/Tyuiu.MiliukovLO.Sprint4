using Tyuiu.MiliukovLO.Sprint4.Task7.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                                ");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  ");
        Console.WriteLine("* Задание #7                                                               ");
        Console.WriteLine("* Вариант #12                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"658932125478\". Преобразуйте ее в    ");
        Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел                        ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        string str = "658932125478";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(3, 4, str));
    }
}