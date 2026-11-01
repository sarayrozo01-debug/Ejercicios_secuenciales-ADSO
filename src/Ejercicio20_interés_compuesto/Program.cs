double capitalinicial, tasainteresmensual, numeromeses, capitalfinal, interesesganados;

Console.Write("Digite la capital inicial: ");
capitalinicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite el porcentaje de interes mensual: ");
tasainteresmensual = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite numero de meses: ");
numeromeses = Convert.ToDouble(Console.ReadLine());

capitalfinal = capitalinicial * Math.Pow((1 + tasainteresmensual / 100), numeromeses);
interesesganados = capitalfinal - capitalinicial;

Console.WriteLine($"La capital final fueron de: {capitalfinal} con interes ganados de: {interesesganados}");
