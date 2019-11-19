import random 
import os

os.system("cls")

naam = input("\u001b[32m Welkom bij kraak de code! Wat is uw naam?: \u001b[31m" )
pogingen = 5

hidden = random.randint(1,99)
print(hidden)

while not pogingen == 0 :
    keer = input(naam + ",\u001b[34m wil je de code kraken? ja of nee: \u001b[31m")
    if keer == "ja":
        pogingen -= 1

    else :
        print("\u001b[37mOke dan stoppen we ermee!")
        print(hidden, "\u001b[37mdit was de code")
        input()
        quit()

    nummer = int(input("\u001b[34mraad een getal onder de 100: \u001b[31m"))

    if nummer == hidden:
        print ("Goed geraden!")
        pogingen = 0
    elif nummer < hidden:
        print ("het getal ligt hoger")
    else:
        print ("het getal ligt lager")


input()