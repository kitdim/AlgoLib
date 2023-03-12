import random
from Lib import *

search = SearchLib()
print(
    "1. Linear search algorithm." +
    "\n2. Recursive linear search algorithm.")
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
