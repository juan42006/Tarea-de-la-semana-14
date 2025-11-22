Ejercicio 5:

# Situación inicial
El programa recibe una frase escrita por el usuario y debe contar cuántas vocales contiene.  
Como las vocales pueden aparecer en mayúscula o minúscula, el programa necesita un método para estandarizar cada carácter antes de analizarlo.

# Proceso
1. La frase se convierte en un array de caracteres:
   char[] frase = Console.ReadLine().ToCharArray();
Esto permite recorrer la frase carácter por carácter.

2. Cada carácter se transforma a mayúscula para simplificar la comparación:
char.ToUpper(frase[i])
De esta forma, 'a' y 'A' se tratan igual.

3. En el switch, cada caso incrementa el contador correspondiente:
case 'A': cont_a++; break;
Esto permite identificar y sumar cada vocal individualmente.
