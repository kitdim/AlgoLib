from Lib import *

lst = [1, 6, 8, 2, -5, 8, 1, 10]
count = len(lst)

search_one = SearchLib()
search = int(input("Enter search number"))
print(search_one.LinerSearch(lst, count-1, 8))
