FebArray = [0, 1]


def Fibonacci(n):
    if n <= 0:
        raise Exception('Invalid Input')
    # else if n == 1 or n == 2:
    #     return n-1
    elif n <= len(FebArray):
        return FebArray[n-1]
    else:
        temp = Fibonacci(n-2) + Fibonacci(n-1)
        FebArray.append(temp)
        return temp


def PrintFibonacci(n):
    a = 0
    b = 1
    for i in range(n):
        print(f"{i}. {a}")
        c = a
        a = b
        b = a + c


try:
    print(Fibonacci(5))
except:
    print("Error")
