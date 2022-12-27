lista = [
    {"Nome": "Eduardo", "Sobrenome": "Pavani"},
    {"Nome": "Ana", "Sobrenome": "Oliveira"},
    {"Nome": "Fabricio", "Sobrenome": "Londero"},
]

def ordenar(item):
    return item['Nome']

lista.sort(key=ordenar)  # ordenar dicionário

for item in lista:
    print(item)
    
    
# outra forma de ordenar é usando o lambda

lista.sort(key=lambda item: item['Sobrenome'])
print(lista)


# se criar uma nova lista
def exibir(lista):
    for item in lista:
        print(item)

l1 = sorted(lista, key=lambda item: item['Sobrenome'])

exibir(l1)

# FUNÇÕES LAMBDAS COMPLEXAS

def executa(funcao, *args):
    return funcao(*args)

def soma(x, y):
    return x + y

def cria_multiplicador(multiplicador):
    def multiplica(numero):
        return numero * multiplicador
    return multiplica

# Todas as linha fazem exatamente a mesma coisa

print(
    executa(
        lambda x, y: x + y,
        2, 3
    ),
    executa(soma, 2, 3),
    soma(2, 3)
)

#Assim é possível calcular o def do def
duplica = executa(
    lambda m: lambda n: n * m 
    2
) 

print(
    executa(
        lambda *args: sum(args),
        1, 2, 4, 8, 12, 15, 22
    )
)



