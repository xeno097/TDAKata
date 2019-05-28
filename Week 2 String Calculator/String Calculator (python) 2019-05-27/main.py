import re

errors = list()

def add(numbers):

    if(len(numbers)==0):
        return 0

    negatives = list()

    separator = str()
    if(numbers[0]=='/' and numbers[1]=='/'):
        numbers = numbers.split('\\n')
        separator = numbers[0][2:]
        numbers = numbers[1]
        numbers = numbers.split(separator)
    else:
        numbers = re.split(r",|\\n",numbers)

    if(numbers[len(numbers)-1]==''):
        errors.append("Number expected but EOF found")
        

    ret = 0.0
    for i in numbers:
        var = to_float(i)
        ret+= var
        if(var<0):
            negatives.append(var)

    if(len(negatives)!=0):
        err = "Negative not allowed:" + str(negatives)
        errors.append(err)

    if(len(errors)!=0):
        for i in errors:
            print(i)
        quit()
        

    return str(ret)

def to_float(num):

    if(len(num)==0):
        errors.append("Invalid number")

    temp = num
    ret = float
    try:
        ret = float(num)
    except ValueError:
        err = "Number expected but found" + str(temp)
        errors.append(err)
        return 0

    return ret

def main():

    var = str(input("insert string: \n"))
    
    print(add(var))


main()