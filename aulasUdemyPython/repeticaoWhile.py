"""
    No Python existe, apenas, os laços 'while' e 'for'

"""

contador = 1
acumulador = 1

while contador <= 10:
    print(contador, acumulador)

    acumulador = acumulador + contador
    contador += 1

# indexando letra por letra em um índice
frase = 'o rato roeu a roupa do rei de roma'  # são 33 caracteres
contador = 0
while contador < len(frase):
    print(contador, frase[contador])
    contador += 1


# indexando letra por letra em uma nova string
contador = 0
nova_string = ''
while contador < len(frase):

    nova_string = nova_string + frase[contador]
    contador += 1
    print(nova_string)

nova_string = nova_string.upper()
print(nova_string)
