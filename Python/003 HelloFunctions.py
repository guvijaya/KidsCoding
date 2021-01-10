# <return type> <FunctionName> ( <datatype> parameter_name, ...)

# No parameter
# No return value
def SayHello():
    print("------------")
    print("Hello")
    print("------------")


def PrintString(str):
    # One parameter, # No return value
    print(str)


def Add(x, y):
    # Two parameter, One return value
    return x + y


def IsPrime(num):
    IsPrime = True
    for x in range(2, num-1):
        if(num % x == 0):
            IsPrime = False
            break

    return IsPrime


def DivisableBy(num):
    ans = 1
    for x in range(2, num):
        if(num % x == 0):
            ans = x
            break

    return ans


x = DivisableBy(121)
print(x)
