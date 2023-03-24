
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Алгоритмы поиска: ");
            Console.WriteLine("1. Линейный поиск");
            Console.WriteLine("2. Рекурсивно-линейный поиск");
            Console.WriteLine("3. Бинарный поиск (в отсортированном массиве)");

            Console.SetCursorPosition(0, 0);
            Console.Write("Выберите нужный алгоритм:");
            var input = Convert.ToInt32(Console.ReadKey());

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
                    Double[] arrBinary = new Double[10];
                    Int32 countArrBinary = arrBinary.Length;

                    foreach (int elem in arrBinary)
                        arrBinary[elem] = elem;
                    foreach (int elem in arrBinary)
                        Console.Write($"{elem} ");
                    var seachValBinary = Convert.ToDouble(Console.ReadLine());

                    SeachLib.BinarySearch(arrBinary, countArrBinary - 1, seachValBinary);
                    break;
                default:
                    Console.WriteLine("Не найдено такого алгоритма.");
                    break;
                    #endregion
            }

        }

    }
}