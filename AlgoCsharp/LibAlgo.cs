class SeachLib
{
    public static string LineSeaching(Double[] arr, Int32 count, Double searchVal)
    {
        Double lastElement = arr[count];
        arr[count] = searchVal;
        Int32 i = 0;
        String result = "Not found";

        for (; arr[i] != searchVal;)
        {
            i += 1;
        }

        arr[count] = lastElement;
        if (i < count || arr[count] == searchVal)
        {
            result = $"Succses: {arr[i]}, index = {i}";
            return result;
        }
        return result;
    }
    public static string RecursiveLinearSearching(Double[] arr, Int32 count, Int32 index, Double searchVal)
    {
        String result = "Not found";

        if (index > count)
        {
            return result;
        }
        else if (index <= count && arr[index] == searchVal)
        {
            result = $"Succses: {arr[index]}, index = {index}";
            return result;
        }
        else if (index <= count && arr[index] != searchVal)
        {
            return RecursiveLinearSearching(arr, count, index + 1, searchVal);
        }
        return result;
    }
    public static string BinarySearch(IList<int> list, int item)
    {
        var lowIndex = 0;
        var highIndex = list.Count() - 1;

        while (lowIndex <= highIndex)
        {
            var midIndex = (lowIndex + highIndex) / 2;
            var guess = list[midIndex];

            if (guess == item)
                return $"Succses.";

            if (guess > item)
                highIndex = midIndex - 1;
            else
                lowIndex = midIndex + 1;
        }
        return "Not found";
    }
    public static string BinarySearchRec(
        IList<int> list, int lowIndex,
        int highIndex, int searchItem)
    {
        if (lowIndex >= highIndex)
            return "\nNot found";
        else
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            var guess = list[middleIndex];

            if (guess == searchItem)
                return "\nFound";
            else if (guess > searchItem)
                return BinarySearchRec(list, lowIndex, highIndex - 1, searchItem);
            else
                return BinarySearchRec(list, lowIndex + 1, highIndex, searchItem);
        }
    }
}