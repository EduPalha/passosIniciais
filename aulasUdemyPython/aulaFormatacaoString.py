"""
    Tudo em Python é um objeto. 
    Python é uma linguagem de tipagem dinâmica.

"""

nome = 'Eduardo'
idade = 27
peso = 73.5

print(nome, 'tem', idade, 'de idade e seu peso é', peso)

#outras formas de fazer, mais elegantes
print(f'{nome} tem {idade} de idade e seu peso é {peso:.0f}') 
print('{} tem {} de idade e seu peso é {}'.format(nome, idade, peso)) 
print('{n} tem {i} de idade e seu peso é {p}'.format(n=nome, i=idade, p=peso))

#fazer cast(converter variável)
print(float(idade) - 73.5)

#entrada de dados

nome = input('Qual o seu nome? ')
idade = int(input('Qual sua idade? '))
print('Fazem', idade - 17, 'anos que', nome, 'saiu do colégio!')