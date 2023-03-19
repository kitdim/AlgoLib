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

    def BinarySearch(self, arr, count, search_value):
        p = 1
        r = count
        while p <= r:
            q = (p + r) // 2
            print(f"p = {p}\tq = {q}\tr = {r}")
            if (arr[q] == search_value):
                print("A line")
                return f"Found: {arr[q]}"
            if (arr[q] != search_value):
                print("В line")
                if (arr[q] > search_value):
                    print("C line")
                    r = q - 1
            if (arr[q] < search_value):
                print("D line")
                r = q + 1
            input()
        return "Not found"
