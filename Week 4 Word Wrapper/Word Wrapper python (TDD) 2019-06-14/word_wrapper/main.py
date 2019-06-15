

class wrapper():

    def wrap(_string: str(), _max_len: int()):

        ret = ""
        _string = _string.split(" ")

        line = ""
        flag = True
        for i in _string:
            temp = line
            check_len = len(temp + i + ' ')
            if(check_len > _max_len):
                ret += temp
                if(len(line) < _max_len):
                    spaces = _max_len-len(line)
                    while(spaces > 0):
                        ret += ' '
                        spaces -= 1
                ret += '\n'
                flag = False
                line = i+' '
            else:
                line += i+' '
                flag = True

        to_add = _string[len(_string)-1]
        if((len(line + to_add) > _max_len)and flag):
            ret += '\n'+to_add
        else:
            ret += to_add

        print(ret)
        return ret


#wrapper.wrap("sol luna cielo", 5)

'''

sol  \nluna \ncielo 
sol  \nluna \ncielo
'''
