'''

   1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
   2. Any live cell with more than three live neighbours dies, as if by overcrowding.
   3. Any live cell with two or three live neighbours lives on to the next generation.
   4. Any dead cell with exactly three live neighbours becomes a live cell.

'''

class gameoflife():

    def __init__(self, _rows, _cols):
        self.n_rows = _rows
        self.n_cols = _cols
        self.grid = []
        self.game = 0
        self.creategrid()

    def creategrid(self):

        for x in range(self.n_rows):
            row = []
            for y in range(self.n_cols):
                row.append('.')

            self.grid.append(row)

    def printgrid(self):

        print("Generation #",self.game)
        for x in range(self.n_rows):
            for y in range(self.n_cols):
                print(self.grid[x][y],end="")
            print()

    def setgrid(self, x, y, val):
        self.grid[x][y]=val

    def play(self):

        for x in range(self.n_rows):
            for y in range(self.n_cols):
                cells = 0
                cells += self.getcell(x-1,y-1)
                cells += self.getcell(x,y-1)
                cells += self.getcell(x+1,y-1)
                cells += self.getcell(x-1,y)
                cells += self.getcell(x+1,y)
                cells += self.getcell(x-1,y+1)
                cells += self.getcell(x,y+1)
                cells += self.getcell(x+1,y+1)

                #if(cells == 3):
                    #print(self.grid[x][y])

                if(cells<2):
                    self.grid[x][y]='.'
                elif(cells>3):
                    self.grid[x][y]='.'
                elif(cells==3):
                    self.grid[x][y]='*'
        self.game+=1

    def getcell(self, x, y):
        if(x>=0 and x<self.n_rows and y>=0 and y<self.n_cols):
            if(self.grid[x][y]=='*'):
                return 1
        return 0

    