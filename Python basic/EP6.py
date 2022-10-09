# Type Converison
x = 10
y = 3.14
z = "20"

print(type(x))
print(type(y))
print(type(z))

result = x + y
print(result)

resultConvInt = x + int(z)
print(resultConvInt)

resultConvStr = str(x) + z
print(resultConvStr)

resultConvFloat = y + float(z)
print(resultConvFloat)

resultConvFloatToStr = str(y) + z
print(resultConvFloatToStr)

print(str(y))
print(int(y))
print(float(z))