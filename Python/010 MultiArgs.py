# This program shows how to pass multiple arguments to a function.
def Foo(**x):
    print(x["one"])


def FooBar(a):
    print(a)


Foo(one=8, two=30, three=45)

Foo(two=30, one=8)

FooBar(45)

d = {"one": 45, "two": 30}

print(d["one"])
