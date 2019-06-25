from nums_dict import *
import math


def Nums_toString(to_string):
    if(to_string == 1):
        return "one dollar"

    if(to_string <= 20):
        return str(nums_dict[to_string]) + " dollars"

    ret = ""
    to_string = str(to_string)
    to_string_length = len(to_string)-1

    for digit in to_string:
        pow10 = math.pow(10, to_string_length)

        if(to_string_length > 1):
            ret += nums_dict[int(digit)] + ' '
            ret += nums_dict[pow10] + ' '
        else:
            ret += nums_dict[int(digit)*pow10] + ' '

        to_string_length -= 1

    ret += "dollars"
    return ret
