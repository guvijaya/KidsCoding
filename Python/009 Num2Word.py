# This program convers given numbers to words.
def InWordsLong(num):
    pos = [" Hundred ", " Thousand ", " Million ", " Billion ", " Trillion "]
    if(num < 1000):
        return InWords(num)
    elif(num < 1000000):
        part1 = int(num / 1000)
        part2 = num % 1000
        return InWords(part1) + pos[1] + InWords(part2)
    elif(num < 1000000000):
        part1 = int(num / 1000000)
        part2 = int(num / 1000) % 1000
        part3 = num % 1000

        print(part1)
        print(part2)
        print(part3)
        return InWords(part1) + pos[2] + InWords(part2) + pos[1] + InWords(part3)


def InWords(num):
    words = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
             "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"]

    tens = ["", "", "Twenty", "Thirty", "Fourty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"]

    hundreds = ["Hundred"]

    if(num >= 0 and num < 20):
        return words[num]
    elif(num < 100):
        digit1 = int(num / 10)
        digit2 = num % 10

        ans = tens[digit1]
        if(digit2 != 0):
            ans = ans + " " + words[digit2]
        return ans
    else:  # 100, 101, ... 158.... 999
        digit1 = int(num / 100)
        digit2 = int(num / 10) % 10
        digit3 = num % 10

        ans = words[digit1] + " " + hundreds[0] + " and " + tens[digit2]
        if(digit3 != 0):
            ans = ans + " " + words[digit3]
        return ans


num = int(input("Enter a number:"))

if(num < 0 or num >= 1000000000):
    print("I don't know")
else:
    print(InWordsLong(num))
