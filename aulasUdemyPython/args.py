# *args são argumentos não nomeados
# **kwargs são argumentos nomeados

def mostrando_argumentos(*args, **kwargs):
    print('Não nomeados: ', args)
    
    #transforma em dicionário/empacota
    for chave, valor in kwargs.items():
        print('Nomeados/empacotando: ', chave, valor)
    

mostrando_argumentos(1, 2, nome='João', qlq=123)


dados_pessoa = {
    'idade' : 27,
    'altura' : 1.74,
}

#técnica de desempacotamento de um dicionário pronto
# mostrando_argumentos(**dados_pessoa)
