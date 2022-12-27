
# Empacotamento, Desempacotamento + Tuplas

nome1, nome2, nome3 = ['Maria', 'Helena', 'Eduardo'] # quantidade de variáveis e valores devem ser a mesma

# Empacotamento

nome1, *resto = ['Maria', 'Helena', 'Eduardo']
print(resto)

nome1, *_ = ['Maria', 'Helena', 'Eduardo']
print(resto)  # objetivo do _ é mostrar que não se pretende usar o resto dos itens, convenção entre desenvolvedores python


# Tupla - lista mutável

nomes = 'Maria', 'Helena', 'Eduardo' # basta não colocar os colchetes
print(nomes)

#ou pode ser feito a conversão

nomes = ['Maria', 'Helena', 'Eduardo']

nomes2 = tuple(nomes)
nomes3 = list(nomes)


#Desempacotamento

print(*nomes) # pega todos os itens de uma vez


 

