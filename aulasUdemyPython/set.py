# Sets - são conjuntos em Python, Diagramas de Venn
# Porém aceitam apenas tipos imutáveis como valor interno
# Sets são eficientes para remover valores duplicados de iteráveis;
#     -Eles não tem índexes;
#     -Eles não garantem ordem;
#     -Eles são iteráveis (for, in, not in);
# Set dentro de set não pode existir, listas e tuplas podem


# Sets são eficientes por serem simples e são mais rápidos
s1 = set("Eduardo")
print(s1)

s1 = {1, 2, 3, 4, 3, 2, 1}  # set
print(s1)

l1 = [1, 2, 3, 4, 3, 2, 1]  # lista
s1 = set(l1)
print(list(s1))

# iterações possíveis de fazer
s1 = {1, 2, 3}
print(3 in s1)

for numero in s1:
    print(numero)

# Métodos úteis: add, update, clear, discard

s1 = set()
s1.add("Luiz")
s1.add(1)
s1.update("Olá Mundo")  # aqui pegar letra por letra e coloca em uma posição diferente
s1.update(("Olá Mundo", 2))  # aqui manda as palavras em uma posição
print(s1)

# s1.clear()
# print(s1)


s1.discard("Olá Mundo")  # por não saber o índice é eliminar o próprio valor em si
print(s1)


# Operadores úteis:
# union
# intersection
# difference
# symetric_difference

# s1 = {1, 2, 3, 4}
# s2 = {4, 5, 6}

# s3 = s2.union(s1)
# print(s3)

# s3 = s2.intersection(s1)
# print(s3)

# s3 = s2.difference(s1)
# print(s3)

# s3 = s2.symetric_difference(s1)
# print(s3)
