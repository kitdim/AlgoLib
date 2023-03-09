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
            i+=1;
        }

        arr[count] = lastElement;
        if (i < count || arr[count] == searchVal)
        {
            result = $"Succses: {arr[i]}";
            return result;
        }
        return result;
    }
}