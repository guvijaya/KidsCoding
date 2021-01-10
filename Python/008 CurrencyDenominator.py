# This program take a number as input and prints position and value of each digit.

num = input("Enter a number: ")
strLen = len(num)

divider = pow(10, strLen-1)

positions = [
    "Ones", "Tens", "Hundreds",
    "Thousands", "Ten thousands", "Hundred thousands",
    "Millions", "Ten millions", "Hundred millions"
]

num = int(num)
digit = []
while divider > 0:
    digit.append(int((num / divider) % 10))
    divider = int(divider / 10)

for i in range(0, strLen):
    print(digit[i], " ", positions[strLen-i-1])
