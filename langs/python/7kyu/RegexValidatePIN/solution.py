from re import compile, fullmatch
def validate_pin(pin):
    # fullmatch match all str
    if fullmatch(compile(r'(\d{4}|\d{6})'), pin) == None:
        return False
    return True

print(validate_pin('098765\n'))
print(validate_pin('098765 '))
print(validate_pin('098765\t'))
print(validate_pin('098765\r'))
print()
print(validate_pin('0987\n'))
print(validate_pin('0987 '))
print(validate_pin('0987\t'))
print(validate_pin('0987\r'))
#print(validate_pin('000000'))
#print(validate_pin('1234'))
