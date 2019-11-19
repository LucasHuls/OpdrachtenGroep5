lengte = float(input("Vul lengte in meters in: "))
gewicht = float(input("Vul gewicht in kg in: "))
geslacht = input("Vul geslacht in (m/v man/vrouw): ")

if geslacht == "v":
    lengte = lengte - 0.06

bmi = (gewicht / (lengte**2))

problemen = bmi

if problemen < 18:
    problemen = str("ondergewicht.")
elif problemen > 25:
    problemen = str("overgewicht.")
elif problemen >= 18:
    problemen = str("een gezond gewicht.")


print("Je BMI is:", round(bmi, 2), "en je hebt", problemen)
input()