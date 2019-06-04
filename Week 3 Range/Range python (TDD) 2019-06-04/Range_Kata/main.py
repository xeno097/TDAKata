

def GetAllPoints(low, high):
    ret = '{'
    for i in range(low,high+1):
        ret+= str(i) +','
    ret=ret[0:len(ret)-1]
    ret+= '}'

    return ret

def EndPoints(low, high):
    return '{' + str(low)+','+str(high)+'}'

def ContainsRange(low, high, b):
    blow = 0
    bhigh = 0

    values = b[1:len(b)-1]
    values = values.split(',')

    if(b[0]=='['):
        blow = int(values[0])
    else:
        blow = int(values[0])+1

    if(b[len(b)-1]==']'):
        bhigh = int(values[1])
    else:
        bhigh = int(values[1])-1

    if(low<=blow and bhigh<=high):
        return True
    
    return False

def Contains(low, high, b):
    values = b[1:len(b)-1]
    values = values.split(',')

    for i in values:
        if(low>int(i) or int(i)>high):
            return False
    
    return True

def AreEqualRange(low, high, b):
        blow = 0
        bhigh = 0

        values = b[1:len(b)-1]
        values = values.split(',')

        if(b[0]=='['):
            blow = int(values[0])
        else:
            blow = int(values[0])+1

        if(b[len(b)-1]==']'):
            bhigh = int(values[1])
        else:
            bhigh = int(values[1])-1

        if(low==blow and bhigh==high):
            return True
        
        return False

def Range(a, b='gt',c=None):
    
    ret = True
    low = 0
    high = 0

    values = a[1:len(a)-1]
    values = values.split(',')

    if(a[0]=='['):
        low = int(values[0])
    else:
        low = int(values[0])+1

    if(a[len(a)-1]==']'):
        high = int(values[1])
    else:
        high = int(values[1])-1

    if(b=='gt'):
        return GetAllPoints(low, high)
    elif(b=='ep'):
        return EndPoints(low, high)
    elif(c=='op'):
        return ContainsRange(low,high,b)
    elif(c=='eq'):
        return AreEqualRange(low, high, b)
    elif(c=='nq'):
        return AreEqualRange(low, high, b) == False
    elif(b[0]!='{'):
        return ContainsRange(low, high, b)
    
    return Contains(low, high, b)

    