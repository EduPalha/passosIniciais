"""é uma condicional de uma linha

<valor> if <condicao> else <outro valor>

"""

#CPF
digito = 9
novo_digito = digito if digito <= 9 else 0 
novo_digito = 0 if digito > 9 else digito
print(novo_digito)

"""
--->Cálculo do primeiro dígito do CPF

Coletar a soma dos 9 primeiros dígitos do CPF multiplicando cada um dos valores por uma contagem regressiva começando de 10

Ex.: 746.824.890-70 (746824890)

    7  4  6  8  2  4  8  9  0
*   10 9  8  7  6  5  4  3  2
    70 36 48 56 12 20 32 27 0

Somar todos os resultados:
= 301

Multiplicar o resultado do somatório por 10:
= 3010

Obter o resto da divisão da conta anterior por 11:
= 3010 % 11 = 7

Se o resultado anterior for maior que 9:
    resultado é 0
contrário disso:
    resultado é o valor da conta(7)






--->Cálculo do segundo dígito do CPF:

Coletar a soma dos 9 primeiros dígitos do CPF, mais o primeiro dígito, multiplicando cada um dos valores por uma contagem regressiva começando de 11

    7   4   6  8  2  4  8  9  0  7
*   11  10  9  8  7  6  5  4  3  2
    77  40  54 64 14 24 40 36 0  14

Somar todos os resultados:
= 363

Multiplicar o resultado do somatório por 10:
= 3630

Obter o resto da divisão da conta anterior por 11:
= 3630 % 11 = 0

Se o resultado anterior for maior que 9:
    resultado é 0
contrário disso:
    resultado é o valor da conta(0)

"""


#Calculando:

cpf_enviado_cliente = '746.824.890-70' .replace('.', '')
novo_cpf_enviado_cliente = '746.824.890-70' .replace('.', '')
novo_cpf_enviado_cliente = cpf_enviado_cliente .replace('-', '')

nove_digitos = cpf_enviado_cliente[:9]
contador_regressivo_1 = 10

resultado_digito_1 = 0
for digito_1 in nove_digitos:
    resultado_digito_1 += int(digito_1) * contador_regressivo_1
    contador_regressivo_1 -= 1
digito_1 = (resultado_digito_1 * 10) % 11
digito_1 = digito_1 if digito_1 <= 9 else 0
print(digito_1)



dez_digitos = nove_digitos + str(digito_1)
contador_regressivo_2 = 11

resultado_digito_2 = 0
for digito_2 in dez_digitos:
    resultado_digito_2 += int(digito_2) * contador_regressivo_2
    contador_regressivo_2 -= 1
digito_2 = (resultado_digito_2 * 10) % 11
digito_2 = digito_2 if digito_2 <= 9 else 0
print(digito_2)



#Vai funcionar em 95% das vezes
cpf_gerado_calculo = f'{nove_digitos}{digito_1}{digito_2}'


if cpf_enviado_cliente == cpf_gerado_calculo:
    print('É válido!')
else:
    print('É inválido!')



import re


#r'' expressão regular
cpf_enviado_cliente = re.sub(
    r'[^0-9]',
    '',
    '746.824.890-70'
)

print(cpf_enviado_cliente)



