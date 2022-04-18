def direction(facing, turn):
    positions = ['N', 'NE', 'E', 'SE', 'S', 'SW', 'W', 'NW']
    #Frente (start + (turn / 45 % 8)) % 8
    #Tras   (start - (turn / 45 % 8)) % 8
    pos = -1
    if turn < 0:
        pos = int((positions.index(facing) - (abs(turn) / 45 % 8)) % 8)
    else:
        pos = int((positions.index(facing) + (turn / 45 % 8)) % 8)
    return positions[pos]

print(direction("SE", -45))