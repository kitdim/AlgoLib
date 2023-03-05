class SearchLib:
    def LinerSearch(self, arr, lenght, search_value):
        last = arr[lenght]
        arr[lenght] = search_value
        i = 0
        result = "not found"

        while (arr[i] != search_value):
            i += 1

        arr[lenght] = last

        if (i < lenght or arr[lenght] == search_value):
            result = arr[i]
            return result

        return result
    
