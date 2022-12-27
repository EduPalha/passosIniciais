# Dicionários em Python (tipo Dict)
# são estruturas do tipo par de "chave"
# e valor
# Chaves podem ser consideradas como índice e podem ser do tipo imutável
# O valor pode ser de qualquer tipo, 
# inclusive outra lista
# Imutáveis: str, int, float, bool, tuple
# Mutáveis: dict, list

pessoa = { 
'nome' : 'Eduardo',
'sobrenome' : 'Pavani',
'endereços' : 
    [
      {'rua': 'silva jardim', 'número' : 1694},
      {'rua' : 'rua venâncio aires', 'número' : 1349},
    ], 
}

print(pessoa)

print(pessoa['nome'])
print(pessoa['sobrenome'])
print(pessoa['endereços'])


pessoas = {}

pessoas['nome'] = 'Fabrício'
pessoas['sobrenome'] = 'Londero'

#del pessoas['sobrenome']

print(pessoas)

if pessoa.get('nome') is None:
    print('Não existe')
else:
    print('Existe')



# Métodos úteis nos dicionários em Python:
# len - quantas chaves
# keys - iterável com as chaves
# values - iterável com os valores
# items - iterável com chaves e valores
# setdefault - adiciona valor se a chave não existe
# copy - retorna uma cópia rasa (shallow copy)
# get - obtém uma chave
# pop - apaga um item com a chave específica (del)
# popitem - apaga o último item adicionado
# update - atualiza um dicionário no outro


print(len(pessoa))

for chave in pessoa.keys():
    print(chave)

print(list(pessoa.values()))

for valor in pessoa.values():
    print(valor)


# for chave, valor in pessoa.values():
#     print(chave, valor)


# print(pessoa.get['endereços'])

pessoa.setdefault('idade', '27')

d1 = {
    'c1' : 1,
    'c2' : 2,
    'l1' : [0, 1, 2],
}

d2 = d1

d2['c1'] = 1000
print(d2)

# tudo o que for imutável vai fazer uma cópia rasa, porém se tiver outro dicionário ou uma lista ele não vai pegar(shallow copy)
d2 = d1.copy()

print(d2)





import copy

#copia profunda
d2 = copy.deepcopy(d1)

pessoa.update(nome = 'novo', sobrenome = 'valor')

tupla = ('nome', 'novo valor'), ('idade', 30)
pessoa.update(tupla)

print(pessoa)




#Empacotamento e Desempacotamento de Dicionários

a, b = 1, 2
a, b = b, a

pessoa = { 
'nome' : 'Eduardo',
'sobrenome' : 'Pavani',
}

# a, b = pessoa.values()
# print(a, b)

# a, b = pessoa.items()
# print(a, b)

# (a1, a2), (b1, b2) = pessoa.items()
# print(a1, a2)
# print(b1, b2)

# for chave, valor in pessoa.items():
#     print(chave, valor)

dados_pessoa = {
    'idade' : 27,
    'altura' : 1.74,
}

# dois asteríscos kwargs
pessoas_completa = {**pessoa, **dados_pessoa,'outros dados' : 1}

print(pessoas_completa)















