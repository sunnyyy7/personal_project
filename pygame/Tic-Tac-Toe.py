#https://www.youtube.com/watch?v=M3G1ZgOMFxo

import random

print("Welcome to the Tic-Tac-Toe")

possibleNumbers = [1,2,3,4,5,6,7,8,9]
gameBoard = [1,2,3], [4,5,6], [7,8,9]
rows = 3
cols =3

def printGameBoard():
    for x in range(rows):
        print("")