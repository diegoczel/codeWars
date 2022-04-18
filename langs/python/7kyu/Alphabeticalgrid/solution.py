def grid(N):
    if N < 0: return None
    s = ''
    for row in range(0, N):
        for col in range(row, N + row):
            s += f"{chr((col % 26)+97)} "
        s = s.rstrip(' ') + '\n'
    return s.rstrip('\n')


print(grid(0))
print(grid(52))