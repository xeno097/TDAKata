from game_of_life import gameoflife


def main():

    n_rows = int(input("Insert the number of rows of your grid game: "))
    n_cols = int(input("Insert the number of colunms of your grid game: "))
    n_games = int(input("Insert the number of games you want to play: "))
    test = gameoflife(n_rows,n_cols)

    for x in range(n_rows):
        row = input()
        for y in range(len(row)):
            test.setgrid(x,y,row[y])


    for i in range(n_games):
        test.play()
        test.printgrid()


main()

