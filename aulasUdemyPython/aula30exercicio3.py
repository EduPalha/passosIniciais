nome = input('Digite seu nome: ')

try:
    if (len(nome) <= 4):
        print('Nome digitado é de tamanho pequeno!')
    elif (len(nome) >= 4 and len(nome) <= 6):
        print('Nome digitado é de tamanho médio!')
    else:
        print('Nome digitado é de tamanho grande!')

except:
    print('Erro')
