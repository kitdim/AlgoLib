using static System.Console;
namespace AlgoCsharp
{
    public static class RunAlgo
    {
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