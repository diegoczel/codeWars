import re
def remove(s):
    return ' '.join([x.rstrip("!") for x in re.findall(r'(!*?\w+)', s)])

print(remove('!!!Hi !!hi!!! !hi'))