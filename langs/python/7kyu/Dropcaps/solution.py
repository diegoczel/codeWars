import re
def drop_cap(str_):
    f = re.compile(r'\w{3,}').findall(str_)
    for x in f:
        str_ = str_.replace(str_, x.capitalize())
    return str_

print(drop_cap('SGtaOv'))