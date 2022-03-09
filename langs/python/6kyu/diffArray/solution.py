def array_diff(a, b):
    #your code here
    for x in b:
        while x in a:
            a.remove(x)
    return a