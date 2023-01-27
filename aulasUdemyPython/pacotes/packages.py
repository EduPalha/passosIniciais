
from sys import path

# toda importação funciona como exportação para outros arquivos
import pacotes

# Traz os diretórios que envolvem o projeto
print(*path, sep='\n')


print(pacotes.dobra(3))