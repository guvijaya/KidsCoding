'''
Functions are usually used to recycle existing code.
This is done by pre-determining what a function does,
passing in parameters, and using return to return a value.
'''

# def <FunctionName> (<Parameters>, ...)

'''
Parameters and Return:
'''

# This function has no parameters of return value
def SayHello():
    print("------------")
    print("Hello")
    print("------------")

# This function has one parameter, and no return value
def PrintString(str):
    print(str)

# This function has two parameter and one return value.
def Add(x, y):
    return x + y

'''
Example Functions:
'''

# Here is an example function.
def IsPrime(num):
    IsPrime = True
    for x in range(2, num-1):
        if(num % x == 0):
            IsPrime = False
            break

    return IsPrime

# Here is another example function
def Iseven(num):
    if num % 2 == 0:
        return True
    else:
        return False

# You can also call other functions in functions
def Isdivisableby3(num):
    if Iseven == True:
        return False
    elif num % 3 == 0:
        return True