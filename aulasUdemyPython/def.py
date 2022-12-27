
def saudacao(nome='Default - Padrão'):
    print(f'Olá, {nome} !')

saudacao('Eduardo')
saudacao('Maria')
saudacao()






x, y, *resto = 1, 2, 3, 4
print(x, y ,resto) # resto gera uma lista


def soma(*args):
    print(args, type(args))


soma(1, 2, 3, 4, 5, 6) # gera uma lista






def criar_saudacao(saudacao):
    def saudar(nome):
        return f'{saudacao}, {nome}'
    return saudar

bomDia = criar_saudacao('Bom dia')
boaNoite = criar_saudacao('Boa noite')

print(bomDia('Eduardo'))
print(boaNoite('Eduardo'))

