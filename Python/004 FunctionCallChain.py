# A function can call other function, that function can intern call another function.

def VishalDoIt():
    print("Please ask Shreya")


def SwethaDoIt():
    print("Vishal do it")
    VishalDoIt()


def ShreyaDoSomething():
    print("Please ask Swetha to do it")
    SwethaDoIt()
    VishalDoIt()


ShreyaDoSomething()
