int monto, billetes_50000, billetes_20000, billetes_10000, billetes_5000, residuo;

Console.Write("Por favor, ingrese el monto que desea retirar pero que sea múltiplo de 5,000: ");
monto = Convert.ToInt32(Console.ReadLine());

billetes_50000 = monto / 50000;
residuo = monto % 50000;
billetes_20000 = residuo / 20000;
residuo = residuo % 20000;
billetes_10000 = residuo / 10000;
residuo = residuo % 10000;
billetes_5000 = residuo / 5000;
residuo = residuo % 5000;

Console.WriteLine($"Cantidad de billetes entregados es billetes de 50000: {billetes_50000}, billetes de 20000: {billetes_20000}, billetes de 10000: {billetes_10000}, billetes de 5000: {billetes_5000} y el resto no entregado es: {residuo}");

