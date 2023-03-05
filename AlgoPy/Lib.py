class SearchLib:
    def LinerSearch(self, arr, count, search_value):
        last = arr[count]
        arr[count] = search_value
        i = 0
        result = "not found"

        while (arr[i] != search_value):
            i += 1

        arr[count] = last

        if (i < count or arr[count] == search_value):
            result = arr[i]
            return result

        return result
