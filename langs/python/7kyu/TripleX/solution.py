def triple_x(s):
    x = s.find('x') 

    if x == -1: return False

    if s[x:x+3] == 'xxx': return True

    return False

valid_x = ['x', 'x\n', 'texte xxx', 'xxx', 'testanto xxx\n', 'xxx xxx']

for x in valid_x:
    print(triple_x(x))