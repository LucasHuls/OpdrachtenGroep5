#LucasHuls - Opdracht 4 Even of oneven getallen.
import os
os.system("cls")




getal=int(input("\u001b[32mVoer een nummer in:\u001b[0m "))

if(getal%2==0):
    print("Het getal\u001b[31m",(getal),"\u001b[0mis een even getal!")
else:
    print("Het getal\u001b[31m",(getal),"\u001b[0mis een oneven getal!")



input("Klik op enter om het scherm te sluiten..." )

if __name__ == "__main__":
    main()