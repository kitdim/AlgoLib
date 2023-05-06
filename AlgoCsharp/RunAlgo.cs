using static System.Console;
namespace AlgoCsharp
{
    public static class RunAlgo
    {
        /// <summary>
        /// Запуск линейного поиска
        /// </summary>
        public static void RunLineSearching()
        {
            var array = Enumerable.Repeat(0, 20)
                        .Select(x => new Random()
                        .Next(-50, 50))
                        .ToArray();
            var count = array.Length - 1;

            foreach (var elem in array)
                Write($"{elem} ");

            Write("\nВведите число для поиска: ");
            var search = int.Parse(ReadLine() ?? "0");
            var result = LibAlgo.LineSearching(array, count, search);

            ForegroundColor = result.Length > 15 ? ConsoleColor.Green : ConsoleColor.Red;
            WriteLine(result);
            ResetColor();
        }

        /// <summary>
        /// Запуск сортировки вставкой
        /// </summary>
        public static void RunInsertSort()
        {
            var list = Enumerable.Repeat(0, 20)
                        .Select(x => new Random()
                        .Next(-50, 50))
                        .ToList();

            WriteLine("Список до сортировки:");
            foreach (var item in list)
                Write(item + " ");

            WriteLine("\nСписок после сортировки:");
            list = LibAlgo.InsertSort(list);
            foreach (var item in list)
                Write(item + " ");
        }
    }
}