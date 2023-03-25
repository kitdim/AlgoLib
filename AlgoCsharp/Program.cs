
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Алгоритмы поиска: ");
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("1. Линейный поиск");
            Console.SetCursorPosition(30, 2);
            Console.WriteLine("2. Рекурсивно-линейный поиск");
            Console.SetCursorPosition(30, 3);
            Console.WriteLine("3. Бинарный поиск (в отсортированном массиве)");

            Console.SetCursorPosition(0, 0);
            Console.Write("Выберите нужный алгоритм: ");
            var input = Convert.ToInt32(Console.ReadLine());

            Console.SetCursorPosition(0, 5);
            switch (input)
            {
                case 1:
                    #region Линейный поиск
                    Double[] arrLinear = new Double[10];
                    Random randomLinear = new Random();
                    Int32 countLinear = arrLinear.Length;

                    for (int i = 0; i < arrLinear.Length; i++) arrLinear[i] = randomLinear.Next(-100, 100);
                    foreach (Double elem in arrLinear) Console.Write($"{elem} ");

                    Console.Write("\nEnter the number: ");
                    Double seachValLinear = double.Parse(Console.ReadLine());

                    Console.WriteLine(SeachLib.LineSeaching(arrLinear, countLinear - 1, seachValLinear));
                    break;
                #endregion

                case 2:
                    #region Рекурсивно-линейный поиск
                    Double[] arrLinearRec = new Double[10];
                    Random randomLinearRec = new Random();
                    Int32 countLinearRec = arrLinearRec.Length;
                    Int32 index = 0;

                    for (int i = 0; i < arrLinearRec.Length; i++)
                        arrLinearRec[i] = randomLinearRec.Next(-100, 100);

                    foreach (Double elem in arrLinearRec)
                        Console.Write($"{elem} ");

                    Console.Write("\nEnter the value: ");
                    var seachValRec = double.Parse(Console.ReadLine());


                    Console.WriteLine(SeachLib.RecursiveLinearSearching(arrLinearRec, countLinearRec - 1, index, seachValRec));
                    break;
                #endregion

                case 3:
                    #region Бинарный поиск
                    List<int> arrBinary = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


                    foreach (var elem in arrBinary)
                    {
                        Console.Write($"{elem} ");
                    }

                    Console.Write("\nВведите число: ");
                    var seachValBinary = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(SeachLib.BinarySearch(arrBinary, seachValBinary));
                    break;
                default:
                    Console.WriteLine("Не найдено такого алгоритма.");
                    break;
                    #endregion
            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}