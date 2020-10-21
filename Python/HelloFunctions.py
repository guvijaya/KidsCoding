# <return type> <FunctionName> ( <datatype> parameter_name, ...)

# No parameter
# No return value
def SayHello():
    print("------------")
    print("Hello")
    print("------------")

# One parameter
# No return value
def PrintString(str):
    print(str)

# Two parameter
# One return value
def Add(x, y):
    return x + y

def IsPrime(num):
    IsPrime = True
    for x in range(2,num-1):
        if( num % x == 0):
            IsPrime = False
            break
    
    return IsPrime

def DivisableBy(num):
    ans = 1
    for x in range(2,num):
        if( num % x == 0): 
            ans = x
            break
    
    return ans

x = DivisableBy(121)
print( x ) 
