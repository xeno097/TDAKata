import re
from errors import *

def string_add(var):

    if(len(var)==0):
        return "0"

    ret = 0
    sep = ""
    if(var[0]=='/' and var[1]=='/'):
        var = var.split("\n")
        sep = var[0][2:]
        var = var[1].split(sep)
    else:
        var = re.split(r",|\n",var)

    for i in var:
        if(int(i)<0):
            raise NegativeNumberError
        ret+=int(i)

    return str(ret)