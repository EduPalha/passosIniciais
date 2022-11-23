hora = int(input('Digite a hora atual: '))
try:
    if (hora >= 0 and hora <= 11):
        print('Bom dia ', hora)
    elif (hora >= 12 and hora <= 17):
        print('Boa tarde ', hora)
    elif (hora >= 24):
        print('Hora nao existente')
    else:
        print('Boa noite ', hora)
except:
    ('Erro')
