def calc_pa(number, multiple):
    # error print(calc_pa(19, 5), '30')
    #print(calc_pa(20, 5), '30')
    if number % multiple == 0: number = number - 1
    
    number_div = number // multiple

    if number_div % 2 == 0:
        return ((multiple) + (number - (number % multiple))) * (number_div / 2)
    return ((multiple) + (number - (number % multiple))) * ((number_div - 1) / 2) + (number - (number % multiple))

print(calc_pa(1, 5), '0')
print(calc_pa(9, 5), '5')
print(calc_pa(10, 5), '5')
print(calc_pa(11, 5), '15')
print(calc_pa(19, 5), '30')
print(calc_pa(20, 5), '30')
print(calc_pa(21, 5), '50')

def solution(number):
    s = 0
    if number < 1: return s

"""
print(solution(0))
print(solution(-1))
print(solution(20))"""