#Laat de gebruiker een waarde opgeven en slaat het op in variabel NUM
nummer = int(input("Welk nummer om tafels 1-10 weer te geven?: "))

#Print de gekozen waarde uit.
print("Tafel van", nummer)

#1 tot 11 zodat 0 niet wordt weergegeven, Nummer x index = (nummer*index)
for i in range(1, 11):
   print(nummer,"X",i,"=",nummer * i)

input()