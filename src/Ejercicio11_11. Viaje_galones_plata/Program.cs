double velocidad, tiempo, distancia, redimiento, precio_galon, galones_necesarios, precio_combustible;

Console.Write("ingrese su velocidad (km/h): ");
velocidad = Convert.ToDouble(Console.ReadLine());

Console.Write("ingrese su tiempo (h): ");
tiempo = Convert.ToDouble(Console.ReadLine());

distancia = velocidad * tiempo;

Console.WriteLine("su diatancia recorrida es de: "+distancia);

Console.Write("ingrese su rendimineto (km/galon): ");
redimiento = Convert.ToDouble(Console.ReadLine());

Console.Write("ingrese el precio del galon: ");
precio_galon = Convert.ToDouble(Console.ReadLine());

galones_necesarios = distancia / redimiento;
precio_combustible = galones_necesarios * precio_galon;

Console.WriteLine("sus galones necesarios fueron: "+galones_necesarios+" y el costo del combustible fue de: "+precio_combustible);



