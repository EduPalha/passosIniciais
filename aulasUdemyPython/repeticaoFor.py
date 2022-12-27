"""
    For é utilizado para coisas finitas
    Iterando string com for
    Função range(start=0, stop, step=1)

"""
texto = "Python S2"

auxiliar = ""
for letra in texto:
    auxiliar = auxiliar + texto[letra]

print(auxiliar)


# usando start, stop e step
for n in range(1, 10, 2):
    print(n)
