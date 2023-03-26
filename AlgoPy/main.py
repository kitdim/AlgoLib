import random
import os
from Lib import *

search = SearchLib()

while True:
    print(
        "1. Linear search algorithm.\n" +
        "2. Recursive linear search algorithm.\n" +
        "3. Binary search algorithm.")
    input_algo = int(input("Enter: "))

    if (input_algo == 1):
        lst = [1, 6, 8, 2, -5, 8, 1, 10]
        count = len(lst)
        print(*lst)
        search_val = int(input("Enter search value: "))
        print(search.LinerSearch(lst, count-1, search_val))

    elif (input_algo == 2):
        lst = [1, 6, 8, 2, -5, 8, 1, 10]
        count = len(lst)
        index = random.choice(lst)
        print(*lst)
        search_val = int(input("Enter search value: "))
        print(search.RecursLinearSearch(lst, count - 1, index, search_val))

    elif (input_algo == 3):
        lst = range(21)
        print(*lst)
        search_val = random.randint(1, 50)
        print(f"Need search: {search_val}")
        print(search.BinarySearch(lst, search_val))
    else:
        print("Not yet.")
        quit()

    input()
    os.system('CLS')
