def assemble(arr):
    if len(arr) == 0: return ''

    r = []
    for i in range(0, len(arr[0])):#loop each letter into str
        asterisk = False
        letter = ''
        for j in range(0, len(arr)):#loop each letter into each element of array
            if arr[j][i] == '*':
                if not asterisk:
                    asterisk = True
                continue
            if letter == '':
                letter = arr[j][i]
                continue
            if arr[j][i] != letter:
                r.append('#')#invalid letter
                break
        if asterisk and letter == '':
            r.append('#')# only * or #
        else:
            r.append(letter)# valid letter
   
    return ''.join(r)

print(assemble([])) # when arr is empty
print(assemble(['H*llo, W*rld!', 'Hel*o, *or*d!', '*ello* World*']))