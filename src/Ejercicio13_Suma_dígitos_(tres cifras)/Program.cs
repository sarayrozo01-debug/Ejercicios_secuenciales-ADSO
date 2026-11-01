
int numero_ingresado, centenas, decenas, unidades, suma_total;

Console.Write("Por favor, ingrese un número entero de tres cifras: ");
numero_ingresado = Convert.ToInt32(Console.ReadLine());

centenas = numero_ingresado / 100;
decenas = (numero_ingresado / 10) % 10;
unidades = numero_ingresado % 10;

suma_total = centenas + decenas + unidades;

Console.WriteLine("La suma de los dígitos es: " + suma_total);
