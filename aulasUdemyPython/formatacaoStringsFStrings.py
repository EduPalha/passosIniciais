"""
s - string
d - int
f - float
<número de dígitos>f
x ou X - Hexadecimal
(Caractere)(><^)(quantidade)
Conversion flags - !r !s !a
"""

variavel = 'ABC'
print(f'{variavel}')
print(f'{variavel: >10}') #esquerda
print(f'{variavel: <10}.') #direita
print(f'{variavel: ^10}.') #centro
print(f'{-1000.4873:+,.1f}')
print(f'{variavel!r}')


print(variavel.zfill(100))