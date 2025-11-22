Ejercicio 6:

# Situación inicial
El usuario ingresa un solo carácter y el programa debe identificar si dicho carácter es:
- una letra,
- un número,
- o un símbolo.

Para lograr esto, el programa usa los valores ASCII, ya que cada carácter tiene un código numérico que permite clasificarlo.

# Proceso
1. Se obtiene el carácter ingresado por el usuario:
   char c = char.Parse(Console.ReadLine());
   
3. El carácter se convierte a mayúscula y luego a su equivalente ASCII:
int ascii = (int)char.ToUpper(c);
Esto facilita la comparación, ya que todas las letras tendrán el mismo rango.

4. Se comparan los rangos ASCII:
. 48–57 para números
. 65–90 para letras
. Cualquier otro rango corresponde a un símbolo

La lógica usada es:
if (ascii >= 48 && ascii <= 57)
Lo que permite clasificar correctamente el carácter.
