'''
Dictionaries are used to store data values in key:value pairs.
A dictionary is a collection which is unordered, changeable and does not allow duplicates.
Dictionaries are written with curly brackets, and have keys and values:
'''
# List of values
lst = ["Shwetha", "Shreya", "Vishal", "Shreya"]
for x in lst:
    print(x)

print("")

for i in range(len(lst)):
    print(lst[i])

# Dictionaries in Python Key : value pair
dic = {"Shwetha": 23,
       "Shreya": 99,
       "Vishal": 24,
       "Lalith": 89}

print("")
for k in dic:  # Iterator gives you all keys
    print(f"Here is {k} : {dic[k]}")

print("Getting value using Key")
print(dic["Shwetha"])
print(dic["Lalith"])
print(dic["Shreya"])
