Ejercicio 8:

# Situación inicial

El usuario ingresa una frase y el programa debe mostrarla invertida.
Se trabaja con arrays de caracteres para poder procesar cada letra, espacio o símbolo individualmente.

# Proceso 

1. Se convierte la frase a un array de caracteres:
c = Console.ReadLine().ToCharArray();
. Cada carácter ocupa una posición en el array, lo que permite manipularlo individualmente.

2. Se invierte el array:

aux = c[i];
c[i] = c[size - i - 1];
c[size - i - 1] = aux;
. Se intercambian los caracteres desde los extremos hacia el centro.
. La frase queda invertida en el mismo array, sin necesidad de uno nuevo.

3. Se imprime la frase invertida:
Console.Write("[{0}]", c[i]);
Se recorren los caracteres del array y se muestran en pantalla, confirmando la inversión.
