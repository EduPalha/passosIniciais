
perguntas = [
    {
        'Pergunta' : 'Qto é 2+2?',
        'Opções' : ['1', '3', '4', '5'],
        'Resposta' : '4',
    },

    {
        'Pergunta' : 'Qto é 5*5?',
        'Opções' : ['25', '3', '100', '8'],
        'Resposta' : '25',
    },

    {
        'Pergunta' : 'Qto é 10/2?',
        'Opções' : ['1', '5', '20', '18'],
        'Resposta' : '5',
    },
]

for pergunta in perguntas:
    print('Pergunta', pergunta['Pergunta'])
    print()


    opcoes = pergunta['Opções']
    for i, opcao in enumerate(opcoes):
        print(f'{i})', opcao)

    print()
    escolha = input('Escolha uma opção: ')


    acertou = False
    escolhaInteiro = None
    qtdOpcoes = len(opcoes)

    if escolha.isdigit():
        escolhaInteiro = int(escolha)

    if escolhaInteiro is not None:
        if escolhaInteiro >= 0 and escolhaInteiro < qtdOpcoes:
            if opcoes[escolhaInteiro] == pergunta['Resposta']:
                acertou = True
    
    if acertou:
        print('Acertou!')
    else:
        print('Errou!')


    print()


