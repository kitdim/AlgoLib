class Algorithms:
    def liner_search(self, arr, count, search_value):
        """Линейный поиск"""

        last = arr[count]
        arr[count] = search_value
        index = 0
        result = "not found"

        while arr[index] != search_value:
            index += 1

        arr[count] = last

        if index < count or arr[count] == search_value:
            result = f"Found: {arr[index]}\nIndex: {index}"
            return result

        return result

    def recurs_linear_search(self, arr, count, index, search_value):
        """Линейный поиск с ипользование рекурсии"""

        result = "Not found"
        if index > count:
            return result
        elif index <= count and arr[index] == search_value:
            result = f"Found: {arr[index]}\nIndex: {index}"
            return result
        elif index <= count and arr[index] != search_value:
            return self.recurs_linear_search(arr, count, index + 1, search_value)
        else:
            return result

    def binary_search(self, arr, search_value):
        """Бинарный поиск"""

        low_index, high_index = 0, len(arr) - 1

        while low_index <= high_index:
            middle_index = (low_index + high_index) // 2
            guess = arr[middle_index]

            if guess == search_value:
                return "Succes."
            if guess > search_value:
                high_index = middle_index - 1
            else:
                low_index = middle_index + 1

        return "Not found."

    def binary_search_rec(self, arr, low_index, high_index, search_val):
        """Бинарный поиск с использование рекурсии"""

        if low_index > high_index:
            return "Not found"
        else:
            middle_index = (low_index + high_index) // 2
            if arr[middle_index] == search_val:
                return "Succes."
            elif arr[middle_index] > search_val:
                return self.binary_search_rec(arr, low_index, high_index - 1, search_val)
            else:
                return self.binary_search_rec(arr, low_index + 1, high_index, search_val)

    def selection_sort(self, arr):
        """Сортировка выбором"""

        if len(arr) - 1 > 1:
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

        if len(arr) <= 1:
            return arr
        size = len(arr)

        for i in range(size):
            key = arr[i]
            j = i - 1

            while j >= 0 and arr[j] > key:
                arr[j + 1] = arr[j]
                arr[j] = key
                j -= 1

        return arr

    def merge_sort(self, arr):
        "Сортировка слиянием"

        if len(arr) < 2:
            return arr
        size = len(arr)
        mid = size // 2
        left_half = arr[:mid]
        right_half = arr[mid:]

        self.merge_sort(left_half)
        self.merge_sort(right_half)
        i = j = k = 0
        while i < len(left_half) and j < len(right_half):
            if left_half[i] < right_half[j]:
                arr[k] = left_half[i]
                i += 1
            else:
                arr[k] = right_half[j]
                j += 1
            k += 1

        while i < len(left_half):
            arr[k] = left_half[i]
            i += 1
            k += 1

        while j < len(right_half):
            arr[k] = right_half[j]
            j += 1
            k += 1

        return arr

    def quick_sort(self, arr, fst, lst):
        """Быстрая сортировка"""

        if lst - fst > 1:
            q = self.partition(arr, fst, lst)
            self.quick_sort(arr, fst, q)
            self.quick_sort(arr, q + 1, lst)

    def partition(self, arr, fst, lst):
        """Перестановка элементов"""

        pivot = arr[fst]
        i = fst + 1
        j = lst - 1

        while True:
            while i <= j and arr[i] <= pivot:
                i = i + 1
            while i <= j and arr[j] >= pivot:
                j = j - 1

            if i <= j:
                arr[i], arr[j] = arr[j], arr[i]
            else:
                arr[fst], arr[j] = arr[j], arr[fst]
                return j
