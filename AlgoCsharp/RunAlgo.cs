using static System.Console;
namespace AlgoCsharp;

public static class RunAlgo
{
    /// <summary>
    /// Запуск линейного поиска
    /// </summary>
    public static void RunLinearSearching()
    {
        var array = HelperFill();
        var count = array.Count - 1;

        foreach (var elem in array)
            Write($"{elem} ");

        Write("\nВведите число для поиска: ");
        var search = int.Parse(ReadLine() ?? "0");
        var result = LibAlgo.LineSearching(array, count, search);

        ForegroundColor = result == "Not found" ? ConsoleColor.Red : ConsoleColor.Green;
        WriteLine(result);
        ResetColor();
    }
    /// <summary>
    /// Запуск рекурсивного-линейного поиска элемента в массиве
    /// </summary>
    public static void RunRecursiveLinearSearching()
    {
        var array = HelperFill();
        var count = array.Count - 1;
        var index = 0;


        foreach (var elem in array)
            Write($"{elem} ");

        Write("\nВведите число для поиска: ");
        var search = int.Parse(ReadLine() ?? "0");
        var result = LibAlgo.RecursiveLinearSearching(array, count, index, search);

        ForegroundColor = result == "Not found" ? ConsoleColor.Red : ConsoleColor.Green;
        WriteLine(result);
        ResetColor();
    }

    /// <summary>
    /// Запуск сортировки вставкой
    /// </summary>
    public static void RunInsertSort()
    {
        var list = HelperFill();

        WriteLine("Список до сортировки:");
        foreach (var item in list)
            Write(item + " ");

        WriteLine("\nСписок после сортировки:");
        list = LibAlgo.InsertSort(list);
        foreach (var item in list)
            Write(item + " ");
    }

    public static void RunMergeSort()
    {
        var list = HelperFill();

        WriteLine("Список до сортировки:");
        foreach (var item in list)
        {
            Write(item + " ");
        }

        WriteLine("\nСписок после сортировки:");

        LibAlgo.MergeSort(list, 0, list.Count - 1);
        foreach (var item in list)
        {
            Write(item + " ");
        }
    }

    /// <summary>
    /// В зависимости от значение аргумента isSort, возвращает заполненный случайными 
    /// или рандомными целыми числами список.
    /// </summary>
    /// <param name="isSort">нужно возвращать порядковый список или нет?</param>
    /// <returns>Список целых чисел</returns>
    private static List<int> HelperFill(bool isSort = false)
    {
        if (!isSort)
        {
            return Enumerable.Repeat(0, 20)
                    .Select(x => new Random()
                    .Next(-50, 50))
                    .ToList();
        }
        return Enumerable.Range(1, 20).ToList<int>();
    }
}
