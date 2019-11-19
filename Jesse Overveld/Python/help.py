import random

pogingen = 0
number = random.randint(999, 9999)
print(number)

naam = input("Welkom bij kraak de code! Wat is uw naam?:")

while True:
    guess = input(naam + ", Welk cijfer denk je?:")
    if guess == number:
        print("goed geraden!") 
        quit()
    elif guess != number:
        for position, cijfer in enumerate(number, 10):
            if cijfer == number[position]:
                print(cijfer, end="")
            elif cijfer not in number:
                print("-", end="")
            else:
                print("?", end="")
        print("")

input()
