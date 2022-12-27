#Imprecisão de Pontos Flutuantes

numero_1 = 0.1
numero_2 = 0.7
numero_3 = numero_1 + numero_2

print(f'{numero_3:.2f}') # 1ª forma
print(round(numero_3, 3)) # 2ª forma



# 3ª Forma

import decimal

numero_3 = decimal.Decimal(numero_1 + numero_2)
print(numero_3)

