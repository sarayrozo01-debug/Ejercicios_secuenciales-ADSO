Double temperatura_C, temperatura_F, temperatura_K;

Console.Write("ingrese la tempertura en c°: ");
temperatura_C = Convert.ToDouble(Console.ReadLine());

temperatura_F = temperatura_C * 1.8 + 32;
temperatura_K = (temperatura_C + 273.15);

Console.WriteLine($"La temperatura en c° es: {temperatura_C}, en f° es: {temperatura_F} y en k° es: {temperatura_K}");
