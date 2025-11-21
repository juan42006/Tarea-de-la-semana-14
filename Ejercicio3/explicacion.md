Ejercicio 3:

# Situación inicial
El programa solicita al usuario un mensaje y necesita procesarlo carácter por carácter.  
Como una cadena (`string`) está formada por caracteres, es necesario convertirla explícitamente en un array para poder recorrerla y mostrar cada símbolo individualmente.

# Proceso
1. Se lee el mensaje completo con `Console.ReadLine()` y se convierte a un array de caracteres con:
   c = Console.ReadLine().ToCharArray();
Este método transforma la cadena en un arreglo, donde cada posición contiene un carácter.

2. Antes de recorrerlo, se muestra la cantidad de caracteres usando:
c.Length
Esto indica cuántos elementos tiene el array.

3. Finalmente, se recorre el arreglo con un bucle for:
for (int i = 0; i < c.Length; i++)
De este modo se imprime cada carácter entre corchetes.
