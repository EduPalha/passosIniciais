frase = "Que fase ein Eduardo?!"
lista_palavras = frase.split()
print(lista_palavras)


for i, frase in enumerate(lista_palavras):
    print(lista_palavras[i].strip())  # corta os espaços gerados no split

print(lista_palavras)
