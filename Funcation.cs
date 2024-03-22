import math

# Function to return the square of a number
def square(x):
    return x * x

# Function to return length in mm given length in inches
def inches_to_mm(length_inches):
    return length_inches * 25.4

# Function to return the square root of a number
def square_root(x):
    return math.sqrt(x)

# Function to return the cube of a number
def cube(x):
    return x ** 3

# Function to return the area of a circle given the radius
def circle_area(radius):
    return math.pi * radius ** 2

# Function to return a greeting given a name
def greet(name):
    return "Hello, " + name + "!"

# Testing the functions
print("Square of 5:", square(5))
print("Length of 2 inches in mm:", inches_to_mm(2))
print("Square root of 16:", square_root(16))
print("Cube of 3:", cube(3))
print("Area of circle with radius 4:", circle_area(4))
print(greet("Alice"))

