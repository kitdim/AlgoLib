class SearchLib:
    def LinerSearch(self, arr, count, search_value):
        """Линейный поиск"""

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
        """Линейный поиск с ипользование рекурсии"""

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

    def BinarySearch(self, arr, search_value):
        """Бинарный поиск"""

        low_index, high_index = 0, len(arr) - 1

        while (low_index <= high_index):
            middle_index = (low_index + high_index) // 2
            guess = arr[middle_index]

            if (guess == search_value):
                return "Succes."
            if (guess > search_value):
                high_index = middle_index - 1
            else:
                low_index = middle_index + 1

        return "Not found."

    def BinarySearchRec(self, arr, low_index, high_index, search_val):
        """Бинарный поиск с использование рекурсии"""

        if (low_index > high_index):
            return "Not found"
        else:
            middle_index = (low_index + high_index) // 2
            if (arr[middle_index] == search_val):
                return "Succes."
            elif (arr[middle_index] > search_val):
                return self.BinarySearchRec(arr, low_index, high_index - 1, search_val)
            else:
                return self.BinarySearchRec(arr, low_index + 1, high_index, search_val)

    def selection_sort(self, arr):
        """Сортировка выбором"""

        if (len(arr) - 1 > 1):
            for i in range(len(arr) - 1):
                smallest = i
                j = i + 1
                while j < len(arr):
                    if arr[j] < arr[smallest]:
                        smallest = j
                    j = j + 1
                arr[i], arr[smallest] = arr[smallest], arr[i]
            return arr

        else:
            return arr

    def insert_sort(self, arr):
        """Сортировка вставкой"""

        if (len(arr) < 1):
            return arr
        size = len(arr)

        for i in range(size):
            key = arr[i]
            j = i - 1

            while j > 0 and arr[j] > key:
                arr[j + 1] = arr[j]
                j -= 1
            arr[j + 1] = key

        return arr
