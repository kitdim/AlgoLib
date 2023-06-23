namespace AlgoCsharp;

class LibAlgo
{
    /// <summary>
    /// Линейный поиск элемента в массиве
    /// </summary>
    /// <param name="arr">неотсортированный массив</param>
    /// <param name="count">количество элементов в массиве</param>
    /// <param name="searchVal">значение для поиска</param>
    /// <returns></returns>
    public static string LineSearching(List<int> arr, int count, int searchVal)
    {
        var lastElement = arr[count];
        var i = 0;
        var result = "Не найдено";
        arr[count] = searchVal;

        while (arr[i] != searchVal)
        {
            i++;
        }

        arr[count] = lastElement;
        if (i < count || arr[count] == searchVal)
        {
            result = $"Найдено, позиция в списке: {i + 1}";
        }

        return result;
    }

    /// <summary>
    /// Рекурсивный-линейный поиск элемента в массиве
    /// </summary>
    /// <param name="arr">неотсортированный массив</param>
    /// <param name="count">количество элементов в массиве</param>
    /// <param name="index">порядковый номер элемента</param>
    /// <param name="searchVal">значение для поиска</param>
    /// <returns></returns>
    public static string RecursiveLinearSearching(List<int> arr, int count, int index, double searchVal)
    {
        if (index > count)
        {
            return "Not found";
        }

        else if (index <= count && arr[index] == searchVal)
        {
            return $"Succses: {arr[index]}, index = {index}";
        }

        else if (index <= count && arr[index] != searchVal)
        {
            return RecursiveLinearSearching(arr, count, index + 1, searchVal);
        }

        return "Not found";
    }
    public static string BinarySearch(List<int> list, int item)
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

    public static List<int> SelectionSort(List<int> list)
    {
        int size = list.Count();
        if (size > 1)
        {
            for (int i = 0; i < size - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (list[j] < list[smallest])
                    {
                        smallest = j;
                    }
                }
                (list[smallest], list[i]) = (list[i], list[smallest]);
            }
            return list;
        }
        else
        {
            return list;
        }

    }
    public static List<int> InsertSort(List<int> list)
    {
        if (list.Count() <= 1)
            return list;

        int size = list.Count();
        for (int i = 1; i < size; i++)
        {
            int key = list[i];
            int j = i - 1;
            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                list[j] = key;
                j--;
            }
        }
        return list;
    }
    public static void MergeSort(List<int> list, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            MergeSort(list, left, middle);
            MergeSort(list, middle + 1, right);

            Merge merge = delegate (List<int> list, int left, int middle, int right)
            {

                var leftArrayLength = middle - left + 1;
                var rightArrayLength = right - middle;
                var leftTempArray = new int[leftArrayLength];
                var rightTempArray = new int[rightArrayLength];
                int i, j;

                for (i = 0; i < leftArrayLength; ++i)
                {
                    leftTempArray[i] = list[left + i];
                }
                for (j = 0; j < rightArrayLength; ++j)
                {
                    rightTempArray[j] = list[middle + 1 + j];
                }

                i = 0;
                j = 0;
                int k = left;

                while (i < leftArrayLength && j < rightArrayLength)
                {
                    if (leftTempArray[i] <= rightTempArray[j])
                    {
                        list[k++] = leftTempArray[i++];
                    }
                    else
                    {
                        list[k++] = rightTempArray[j++];
                    }
                }

                while (i < leftArrayLength)
                {
                    list[k++] = leftTempArray[i++];
                }
                while (j < rightArrayLength)
                {
                    list[k++] = rightTempArray[j++];
                }
            };
            merge(list, left, middle, right);
        }
    }
    delegate void Merge(List<int> list, int left, int middle, int right);
}

