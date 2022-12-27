# string = 'ABCDE'
# print(bool([]))
# print(lista, type(lista))

# lista = [123, True, 'Luiz Otávio', 1.2, []]
# print(lista)


lista = [10, 20, 30, 40]
lista.append("Eduardo")
nome = list.pop([3])  # se não for setado ele remove sempre no final
lista.append(1233)
del lista[-1]  # sempre é o último elemento (de trás para frente)
print(lista)

lista.insert(
    1, 5
)  # sempre tem dois argumentos, primeiro em qual índice e o segundo o valor

# lista.clear() #limpar a lista


listaA = [1, 2]
listaB = [3, 4, 5]
listaC = listaA + listaB  # concatenação
print(listaC)
listaD = listaA.extend(listaB)  # essa ação também concatena, mas retorna nada
print(listaD)


# DADOS MUTÁVEIS

# MODELO 1
listaA = ["Eduardo", "Pavani"]
listaB = listaA
listaA[0] = "Qualquer coisa"
print(listaB)

# MODELO 2
listaA = ["Eduardo", "Pavani"]
listaB = listaA.copy()
listaA[0] = "Qualquer coisa"
print(listaA)
print(listaB)

# Enumerate

lista = ["Marcelo", "Roger"]
lista_enumerada = enumerate(lista)
print(
    next(lista_enumerada)
)  # depois que for realizado o for, ou seja, consumir os dados o enumerator é zerado quando chega no final da lista

for item in lista_enumerada:
    print(item)

# ou se tu não quer zerar a lista enumerada

for item in enumerate(lista):
    print(item)

# Técnica criada pelos desenvolvedores do Python para enumerar de forma fácil uma lista|tupla
for i, item in enumerate(lista):
    print(i, item)
