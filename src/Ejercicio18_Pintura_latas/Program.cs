double metroscuadrados, rendimiento, litrosporlata, rendimientoporlata, latasusasdas, litrossueltos;

Console.Write("Digite la cantidad de metros cuadrados a pintar: ");
metroscuadrados = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite el valor de rendimiento (metrocuadrado/litro)");
rendimiento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite la cantidad de litros por lata de pintura: ");
litrosporlata = Convert.ToDouble(Console.ReadLine());

rendimientoporlata = metroscuadrados / rendimiento;
latasusasdas = rendimientoporlata / litrosporlata;
litrossueltos = latasusasdas % 2;

Console.WriteLine($"Los metros cuadrados a pintar son: {metroscuadrados}, el rendimiento es de: {rendimiento}(metroscuadrados/litro). La cantidad de litros por lata de pintura son: {litrosporlata}. Entonces usaste: {latasusasdas} latas de pintura y te sobraron {litrossueltos}.");




