def explode(s):
    r = ''
    for x in s:
        if x == '0':
            continue
        r += x * int(x)
    return r

print(explode('312'))
print(explode('102269'))