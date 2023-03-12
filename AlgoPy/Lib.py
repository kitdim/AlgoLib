class SearchLib:
    def LinerSearch(self, arr, count, search_value):
        last = arr[count]
        arr[count] = search_value
        index = 0
        result = "not found"

        while (arr[index] != search_value):
            index += 1

        arr[count] = last

        if (index < count or arr[count] == search_value):
            result = f"Found: {arr[index]}\nIndex: {index}"
            return result

        return result

    def RecursLinearSearch(self, arr, count, index, search_value):
        result = "Not found"
        if (index > count):
            return result
        elif (index <= count and arr[index] == search_value):
            result = f"Found: {arr[index]}\nIndex: {index}"
            return result
        elif (index <= count and arr[index] != search_value):
            return self.RecursLinearSearch(arr, count, index + 1, search_value)
        else:
            return result
