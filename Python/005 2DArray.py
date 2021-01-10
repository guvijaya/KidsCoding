'''
Python does not have built-in support for Arrays, we use List.
List is a special variable, which can hold more than one value at a time.


Method	Description
append()	Adds an element at the end of the list
clear()	Removes all the elements from the list
copy()	Returns a copy of the list
count()	Returns the number of elements with the specified value
extend()	Add the elements of a list (or any iterable), to the end of the current list
index()	Returns the index of the first element with the specified value
insert()	Adds an element at the specified position
pop()	Removes the element at the specified position
remove()	Removes the first item with the specified value
reverse()	Reverses the order of the list
sort()	Sorts the list
'''


def SingleDimention():
    x = 34  # variable
    y = [64, 55, 666, 533]  # set of values use array

    print(x)
    print(y)

    names = ["Lalith", "Shravan", "Swetha"]
    marks = [43, 53, 666, 90]

    print(names)

    print(names[0])
    print(names[1])
    print(names[2])

    print(marks)


def TwoDimentionExample():
    names = [["Lalith", "Music"],
             ["Shravan", "Math"],
             ["Swetha", "Art"]
             ]

    for i in names:
        print("Let's print the array:", i)

        print("Let's print each element of the inner array")
        for y in i:
            print(y)
        print("")

    allmarks = [
        [34, 24, 53, 66],
        [40, 44, 23, 56],
        [34, 40, 3, 60],
    ]

    print(allmarks)


def StaggeredArray():
    a = [[11, 12, 5, 2],
         [15, 6, 10],
         [10, 8, 12, 5],
         [12, 15, 8, 6],
         []
         ]

    # this will print the 4th array
    print("An element in the staggered array")
    print(a[3])

    # You can access a particular index
    print("An index in the staggered array")
    print(a[2][1])

    print("All elements")
    # Loop thru the items
    for x in a:  # takes each
        for y in x:  # each element in the array
            print(y, end=" ")
        print(" ")


SingleDimention()
TwoDimentionExample()
StaggeredArray()
