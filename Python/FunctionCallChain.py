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