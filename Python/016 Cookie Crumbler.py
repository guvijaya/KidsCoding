print("Do you know how to play cookie crumbler?")
if input("Yes/No: ") == "No":
    print('''Welcome to cookie crumbler!
    This is a game about strategy and forward thinking!''')
    print()
    print('''How to play the game:
    Be the person to eat the last cookie!
    There are 15 cookies.
    Each turn you can eat up to 3 cookies.''')
    print()
    print("Good luck!")

playerturn = 1
cookies = 15
exit = False

while exit == False:
    print()
    print("It is player #{0}'s turn. How many cookies would they like to eat?".format(playerturn))
    ce = int(input())
    if ce < 1 or ce > 3:
        print()
        print("That was too high or too low!")
        print("Remember the range is 1-3")
        continue
    if cookies - ce < 0:
        print()
        print("There are/is only {0} cookie(s) left".format(cookies))
        print("You can't eat more than that!")
        continue
    cookies = cookies - ce
    if cookies == 0:
        print()
        print("Player {0} won!".format(playerturn))
        break
    if playerturn == 1:
        playerturn = 2
    else:
        playerturn = 1
    print()
    print("There are {0} cookie(s) left".format(cookies))

    
    