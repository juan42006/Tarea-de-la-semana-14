Ejercicio 2:

# Situación inicial
El ejercicio busca mostrar que un array de caracteres puede inicializarse de diferentes formas en C#, y que sin importar la sintaxis utilizada, el resultado es un arreglo válido con el mismo tamaño y contenido.

# Proceso
1. Se crean tres arreglos distintos usando tres métodos diferentes:

   - Inicialización directa
     char[] a1 = { 'a', 'b', 'c' };
     Aquí el compilador deduce automáticamente el tamaño del array.

   - Inicialización explícita con `new` 
     char[] a2 = new char[] { 'a', 'b', 'c' };
     Se escribe el tipo completo, aunque el resultado es el mismo.

   - Declaración por tamaño + asignación por índice
     char[] a3 = new char[3];
     a3[0] = 'a';
     Se especifica el tamaño y luego se asignan los elementos.

2. Finalmente, se imprime el tamaño de los tres arrays utilizando la propiedad:
   a1.Length
Lo cual devuelve la cantidad de elementos del arreglo.
