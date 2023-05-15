from random import *
import os
from Algorithms import *

search = Algorithms()
rnd = Random()

while True:
    print(
        "1. Linear search algorithm.\n" +
        "2. Recursive linear search algorithm.\n" +
        "3. Binary search algorithm.\n" +
        "4. Binary search using recursion.\n" +
        "5. Selection sorting.\n" +
        "6. Insert sort.")

    input_algo = int(input("Enter: "))

    if input_algo == 1:
        lst = [1, 6, 8, 2, -5, 8, 1, 10]
        count = len(lst)
        print(*lst)
        search_val = int(input("Enter search value: "))
        print(search.liner_search(lst, count - 1, search_val))

    elif input_algo == 2:
        lst = [1, 6, 8, 2, -5, 8, 1, 10]
        count = len(lst)
        index = rnd.choice(lst)
        print(*lst)
        search_val = int(input("Enter search value: "))
        print(search.recurs_linear_search(lst, count - 1, index, search_val))

    elif input_algo == 3:
        lst = range(21)
        print(*lst)
        search_val = rnd.randint(-20, 50)
        print(f"Need search: {search_val}")
        print(search.binary_search(lst, search_val))

    elif input_algo == 4:
        lst = range(21)
        low_index = lst[0]
        high_index = lst[-1]
        search_val = rnd.randint(-20, 50)
        print(*lst)
        print(f"Need search: {search_val}")
        print(search.binary_search_rec(lst, low_index, high_index, search_val))

    elif input_algo == 5:
        lst = [randint(-10, 10) for i in range(20)]

        print("Before sort:")
        print(*lst)
        search.selection_sort(lst)
        print("After sort:")
        print(*lst)
    elif input_algo == 6:
        lst = [randint(-10, 10) for i in range(20)]
        print("Before sort:")
        print(*lst)
        search.insert_sort(lst)
        print("After sort:")
        print(*lst)
    else:
        print("Not yet.")
        quit()

    input()
    os.system('CLS')
