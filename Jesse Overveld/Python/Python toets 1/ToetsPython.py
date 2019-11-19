teama = input("Voer de score in van team A: ")
teamb = input("Voer de score in van team B: ")

if (teama > teamb):
    print("Team A 3 punten en team B heeft 0 punten")
elif (teamb > teama):
    print("Team B 3 punten en team A heeft 0 punten")
elif (teamb == teama):
    print("Team A 1 punt en Team B 1 punt")
input()