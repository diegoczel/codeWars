def spiral_sum(size):
    if size % 2 == 0:
        # when size is odd, then last number is 3.
        # (size - 1 + 3) last number element
        # ( size - 2 ) / 2) len of elements
        # 1 + size add this of len of spiral
        return int(( (size - 1 + 3) * ( ( size - 2 ) / 2) + 1 + size ))
    else:
        # when size is even, then last number is 2
        # (size - 1 + 2) last number element
        # (size - 1) / 2 ) len of elements
        # size add size of len of spiral
        return int(( (size - 1 + 2) * ( (size - 1) / 2 ) + size ))

#print(spiral_sum(5))
#print(spiral_sum(10))
#print(spiral_sum(1000))
#print(spiral_sum(123456))
print(spiral_sum(584757902734057049235907840235937429075234))
#print(170970902404966449586247098818855152577703352208312361219119749622850433204474609664 == 170970902404966462328920047488181969596690166234976092377640121561715772973645152611)
#print(170970902404966462328920047488181969596690166234976092377640121561715772973645152611)