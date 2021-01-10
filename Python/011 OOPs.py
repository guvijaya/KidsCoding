# Object oriented programming
import math


class Circle:
    def __init__(self, r):
        self.Radius = r

    def GetArea(self):
        return 3.14 * self.Radius * self.Radius

    def GetCircumference(self):
        return 2 * 3.14 * self.Radius


class Rectangle:
    def __init__(self, l, w):
        self.Length = l  # Property 1
        self.Width = w  # Property 2

    @staticmethod
    def GetFormula():
        # return Self.Length * Self.Width
        return "Length * Width"

    def GetArea(self):
        return self.Length * self.Width

    def GetPerimeter(self):
        return 2 * (self.Width + self.Length)


class Square:
    def __init__(self, s):
        self.Side = s

    def GetArea(self):
        return self.Side * self.Side

    def GetPerimeter(self):
        return 4 * self.Side


a = Circle(6)

print(a.GetArea())
print(a.GetCircumference())


# Static method should be called using class name
# Instance method should be called using instance obj
