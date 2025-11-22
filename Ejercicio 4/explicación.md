Ejercicio 4:

# Situación inicial
El ejercicio busca unir un saludo base (“Bienvenido a ”) con el nombre ingresado por el usuario, pero sin usar la forma tradicional de juntar cadenas con el operador (+).  
En lugar de eso, se trabaja directamente con **arrays de caracteres**, por lo que es necesario manipular tamaños y posiciones manualmente.

# Proceso
1. El saludo inicial se convierte en un array de caracteres:
   char[] s = "Bienvenido ".ToCharArray();
Esto convierte cada letra del saludo en un elemento del array.

2. El nombre ingresado también se transforma en un array:
n = Console.ReadLine().ToCharArray();

3. Se amplía el tamaño del array s para que pueda contener al nombre completo:
Array.Resize(ref s, lim1 + lim2);
Aquí lim1 es el tamaño del saludo y lim2 el tamaño del nombre.

4. Se copian uno por uno los caracteres del nombre al final del array s:
s[lim1 + i] = n[i];
