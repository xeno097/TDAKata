

class InvalidNumber(Exception):
    """ It is raised when a string cannot be converted to a number """

    def __init__(self,arg):
        print("Number expected but found",arg)