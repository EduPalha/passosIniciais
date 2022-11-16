numero = input('Digite um número inteiro: ')

    try:
        numero = float(numero)
        if (numero.is_integer()):
            if(numero % 2 == 0):
                print('Número Par')
            else:
                print('Número Ímpar')
        else:
            print('Não é número inteiro')
        
    except:
        print('Erro')

