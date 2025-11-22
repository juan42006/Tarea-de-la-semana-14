Ejercicio 7:

# Situación inicial
El usuario debe ingresar varios números enteros y el programa mostrarlos en orden inverso.
El objetivo es practicar cómo trabajar con arrays, pasar arrays a funciones y modificarlos directamente.

# Proceso
1. Se solicita al usuario el tamaño del array y los valores:
size = int.Parse(Console.ReadLine());
a[i] = int.Parse(Console.ReadLine());
. size define cuántos elementos tendrá el array.
. Cada valor ingresado se almacena en la posición correspondiente del array.

2. Se invierten los elementos del array:
aux = a[i];
a[i] = a[size - i - 1];
a[size - i - 1] = aux;
. Se intercambian los elementos desde los extremos hacia el centro.
. La función modifica directamente el array original, sin crear uno nuevo.

3. Se imprime el array invertido:
Console.Write("[{0}]", a[i]);
Se recorren los elementos y se muestran entre corchetes para ver claramente el resultado.
