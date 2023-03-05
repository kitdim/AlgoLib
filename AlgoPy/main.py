from Lib import *

lst = [1, 6, 8, 2, -5, 8, 1, 10]
count = len(lst)
print(count)

search_one = SearchLib()
print(search_one.LinerSearch(lst, count, 8))
