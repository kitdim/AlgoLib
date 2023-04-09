using System.Collections.Generic;
using static System.Console;
class Program
{
    static void Main()
    {

        while (true)
        {
            #region Перечень алгоритмов
            SetCursorPosition(35, 0);
            WriteLine("Алгоритмы поиска: ");
            SetCursorPosition(35, 1);
            WriteLine("1. Линейный поиск");
            SetCursorPosition(35, 2);
            WriteLine("2. Линейный поиск через рекурсию");
            SetCursorPosition(35, 3);
            WriteLine("3. Бинарный поиск (в отсортированном массиве)");
            SetCursorPosition(35, 4);
            WriteLine("4. Бинарный поиск через рекурсию (в отсортированном массиве)");
            SetCursorPosition(35, 5);
            WriteLine("-------------------------------------------------------------");
            SetCursorPosition(35, 6);
            WriteLine("Алгоритмы сортировки");
            SetCursorPosition(35, 7);
            WriteLine("5. Сортировка выбором.");
            #endregion

            SetCursorPosition(0, 0);
            Write("Выберите нужный алгоритм: ");
            var input = Convert.ToInt32(ReadLine());

            SetCursorPosition(0, 10);
            switch (input)
            {
                #region Линейный поиск
                case 1:
                    Double[] arrLinear = new Double[10];
                    Random randomLinear = new Random();
                    Int32 countLinear = arrLinear.Length;

                    for (int i = 0; i < arrLinear.Length; i++) arrLinear[i] = randomLinear.Next(-100, 100);
                    foreach (Double elem in arrLinear) Write($"{elem} ");

                    Write("\nEnter the number: ");
                    Double seachValLinear = double.Parse(ReadLine() ?? "0");

                    WriteLine(SeachLib.LineSeaching(arrLinear, countLinear - 1, seachValLinear));
                    break;
                #endregion

                #region Рекурсивно-линейный поиск
                case 2:
                    Double[] arrLinearRec = new Double[10];
                    Random randomLinearRec = new Random();
                    Int32 countLinearRec = arrLinearRec.Length;
                    Int32 index = 0;

                    for (int i = 0; i < arrLinearRec.Length; i++)
                        arrLinearRec[i] = randomLinearRec.Next(-100, 100);

                    foreach (Double elem in arrLinearRec)
                        Write($"{elem} ");

                    Write("\nEnter the value: ");
                    var seachValRec = double.Parse(ReadLine() ?? "0");


                    WriteLine(SeachLib.RecursiveLinearSearching(arrLinearRec, countLinearRec - 1, index, seachValRec));
                    break;
                #endregion

                #region Бинарный поиск
                case 3:
                    List<int> arrBinary = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


                    foreach (var elem in arrBinary)
                    {
                        Write($"{elem} ");
                    }

                    Write("\nВведите число: ");
                    var seachValBinary = Convert.ToInt32(ReadLine());

                    WriteLine(SeachLib.BinarySearch(arrBinary, seachValBinary));
                    break;
                #endregion

                #region Бинарный поиск через рекурсию
                case 4:

                    var listBinarySearch = Enumerable.Range(1, 20).ToList<int>();
                    var rnb = new Random();
                    var searchItemRec = rnb.Next(50);
                    var highIndex = listBinarySearch.Count();
                    var lowIndex = listBinarySearch[0];

                    WriteLine("Ищем: {0}\nКоличество элементов: {1}",
                    searchItemRec, listBinarySearch.Count());
                    WriteLine("Список в котором осуществляем поиск: ");
                    foreach (var x in listBinarySearch)
                        Write(x + " ");

                    WriteLine(SeachLib.BinarySearchRec(listBinarySearch, lowIndex,
                    highIndex, searchItemRec));

                    break;
                #endregion

                #region Сортировка выбором
                case 5:
                    var listAfter = new List<int>();
                    var listBefore = Enumerable.Repeat(0, 20)
                        .Select(x => new Random()
                        .Next(-50, 50))
                        .ToList();

                    WriteLine("Список до сортировки:");
                    foreach (var item in listBefore)
                        Write(item + " ");

                    WriteLine("\nСписок после сортировки:");
                    listAfter = SeachLib.SelectionSort(listBefore);
                    foreach (var item in listAfter)
                        Write(item + " ");

                    break;
                #endregion

                default:
                    WriteLine("Не найдено такого алгоритма.");
                    break;

            }

            ReadKey();
            Clear();
        }

    }
}
// listBinarySearch = Enumerable.Repeat(0, 20).Select(x => rnb.Next(-50, 50)).ToList<int>();