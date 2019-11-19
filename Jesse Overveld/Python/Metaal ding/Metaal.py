ja = False
werkuren = int(input("Aantal werkuren: "))
leeftijd = int(input("Leeftijd machine: "))
storingen = int(input("Aantal storingen dit jaar: "))

if werkuren > (10000):
    print("Vervanging nodig.")
    ja = True
elif leeftijd >= 7:
    print("Vervanging nodig.")
    ja = True
elif storingen > 25:
    ja = True
    print("Vervanging nodig.")
if ja == False:
    print("Geen vervanging nodig.")

input()

