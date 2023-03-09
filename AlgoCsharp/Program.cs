
class Program
{
    static void Main()
    {
        Double[] arr = new Double[10];
        Random random = new Random();
        Int32 count = arr.Length;

        Console.WriteLine("Linear search:");
        for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(-100, 100);
        foreach (Double elem in arr) Console.Write($"{elem} ");

        Console.Write("\nEnter the number: ");
        Double seachVal = double.Parse(Console.ReadLine());

        Console.WriteLine(SeachLib.LineSeaching(arr, count - 1, seachVal));
    }
}