"""
Formatando valores com modificadores:
    :s - texto (strings)
    :d - inteiros (int)
    :f - pontos flutuantes (float)
    :.(nº)f - quantidade de casas decimais (float) :.2f(exemplo)
    : (caracter) (> ou < ou ) (quantidade) (tipo). Exemplo: peso:0<2
    
"""

peso = 74.7
print(f'{peso:0<21}')
print(f'{peso:0>21}')
print(f'{peso:0^21}')
peso_formatado = '{0:$^30}'.format(peso)
print(peso_formatado)


nome = 'Eduardo PAVANI palharini'
print(nome.lower())
print(nome.upper())
print(nome.title())

"""
Manipulando Strings:
    string indices
    fatiamento de strings[inicio:fim:passo]
    funções built-in: len, abs, type, print, etc(podem ser usadas direto)
    
    https://docs.python.org/3/library/stdtypes.html (tipos)
    https://docs.python.org/3/library/functions.html (funções)
    
"""

texto = 'Python S2'
# quando se quer acessa o índice de uma string
print(texto[2])  # vai ser a letra 't'

# quando se quer buscar de uma posição da string à outra
print(texto[2:6])  # vai ser a subpalavra 'thon'
print(texto[-7:-3])  # busca da direita para esquerda

# quando se quer pular de caracter em caracter(sendo o último item de quanto em quanto)
print(texto[0:6:2])  # vai ser a subpalavra 'pto'
print(texto[0::3])  # vai ser a subpalavra 'ph '
