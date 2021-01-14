# Lists are used to store mulitple values in one variable
# For example:
cars = ["Ford", "Volvo", "BMW", "Hyndai", "Toyota", "Kia", "Tesla"]
print(cars)

# List items are ordered, changeable, and allow duplicate values.
# List items are indexed, the first item has index [0], the second item has index [1] etc.


# In order to access the individual values, you have to follow the following example:

print(cars[1])

# If you want to print each one, you can do this:

for x in range (0, len(cars)):
    print(cars[x])

# You can also do this in reverse:
# Also, because the len(cars) starts counting at 1,
# subtract 1 for it to make sense

for x in range(0, len(cars)):
    print(cars[(len(cars) - 1) - x])

# There are mulitple methods to lists.
# Here are some of them.

# This one adds the value given.
cars.append("Chevrolet")
print(cars)

# This one clears all the value in a list.
cars.clear()
print(cars)

# This just brings back everything in the last because,
# we cleared 
cars = ["Ford", "Volvo", "BMW", "Hyndai", "Toyota", "Kia", "Tesla"]

# This one copies everything in a list
carsfake = cars.copy()
print(carsfake)

# This one gives the amount of times the value has been
# used inside of the list
print(cars.count("BMW"))

# This one adds a list to another list
companies = ["Apple","Microsoft","Google","Samsung"]
companies.extend(cars)
print(companies)

# Gives the position of the given item
print(cars.index("Tesla"))

# This one adds the given item at a given location
cars.insert(0, "Chevrolet")
print(cars)

# This one deletes a specified item using the position
cars.pop(0)
print(cars)

# This one deletes the first instance of the item
# with the value given
cars.remove("Kia")
print(cars)

# This one reverse the list
cars.reverse()
print(cars)

# This one sorts the list (either alphabetically or numerically)
cars.sort()
print(cars)

# You can also store lists in lists
Cardcambos = [["King","Queen","Jack"], ["Queen", "King", "Jack"], ["Jack","King","Queen"]]
print(Cardcambos[2])