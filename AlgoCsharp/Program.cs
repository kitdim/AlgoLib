using System.Collections.Generic;
using static System.Console;
using AlgoCsharp;
class Program
{
    static void Main()
    {

        while (true)
        {
            ForegroundColor = ConsoleColor.Green;

            //TODO Выделить перечень алгоритмов в отдельный текстовый файл, считывать его и выводить
            #region Перечень алгоритмов
            SetCursorPosition(35, 0);
            WriteLine("Алгоритмы поиска: ");
            SetCursorPosition(35, 1);
            WriteLine("1. Линейный поиск.");
            SetCursorPosition(35, 2);
            WriteLine("2. Линейный поиск через рекурсию.");
            SetCursorPosition(35, 3);
            WriteLine("3. Бинарный поиск (в отсортированном массиве).");
            SetCursorPosition(35, 4);
            WriteLine("4. Бинарный поиск через рекурсию (в отсортированном массиве).");
            SetCursorPosition(35, 5);
            WriteLine("-------------------------------------------------------------");
            SetCursorPosition(35, 6);
            WriteLine("Алгоритмы сортировки");
            SetCursorPosition(35, 7);
            WriteLine("5. Сортировка выбором.");
            SetCursorPosition(35, 8);
            WriteLine("6. Сортировка вставкой.");
            ResetColor();
            #endregion

            SetCursorPosition(0, 0);
            Write("Выберите нужный алгоритм: ");
            var input = Convert.ToInt32(ReadLine());

            SetCursorPosition(0, 10);
            switch (input)
            {
                // TODO сделать отдельный класс, который будет выводить и передовать нужные параметры в класс который реализует алгоритмы
                #region Линейный поиск
                case 1:
                    RunAlgo.RunLinearSearching();
                    break;
                #endregion

                #region Рекурсивно-линейный поиск
                case 2:
                    RunAlgo.RunRecursiveLinearSearching();
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

                    WriteLine(LibAlgo.BinarySearch(arrBinary, seachValBinary));
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

                    WriteLine(LibAlgo.BinarySearchRec(listBinarySearch, lowIndex,
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
                    listAfter = LibAlgo.SelectionSort(listBefore);
                    foreach (var item in listAfter)
                        Write(item + " ");

                    break;
                #endregion

                #region Сортировка вставкой
                case 6:
                    RunAlgo.RunInsertSort();
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