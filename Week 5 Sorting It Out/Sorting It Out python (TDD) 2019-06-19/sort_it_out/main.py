

class Rack():

    def __init__(self):
        self.Balls = list()

    def Add(self, to_add):
        if(len(self.Balls) == 0):
            self.Balls.append(to_add)
            return

        self.Sort(to_add)

    def Sort(self, to_add):
        temp_list = list()
        flag = True
        for i in self.Balls:
            if(to_add <= i and flag):
                temp_list.append(to_add)
                flag = False
            temp_list.append(i)

        self.Balls = temp_list


class StringRack():

    def __init__(self, string):
        self.SortedString = string
        self.SortString()

    def SortString(self):
        string = self.SortedString.lower()

        string = [char for char in string if(char.isalpha())]
        temp = dict()
        letters = 'abcdefghijklmnopqrstuvwxyz'

        for l in letters:
            temp[l] = 0

        for l in string:
            temp[l] += 1

        test = list(temp)

        ret = ''
        for l in letters:
            ret += l*temp[l]

        self.SortedString = ret
