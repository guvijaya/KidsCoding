# This program adds two two-dimention lists.
def AddMatrix(a, b):
    ans = []  # Array
    for i in range(0, 3):
        ansrow = []  # Array
        for j in range(0, 3):
            # ansrow we are adding each number
            ansrow.append(a[i][j] + b[i][j])

        # we are adding an array
        ans.append(ansrow)
    return ans


def PrintArr(x):
    for i in x:
        print(i)
    print(" ")


a = [[45, 23, 5],
     [5, 9, 21],
     [9, 53, 9]
     ]

b = [[5, 3, 1], [2, 9, 1], [4, 3, 0]]

PrintArr(a)
PrintArr(b)

c = AddMatrix(a, b)

PrintArr(c)
