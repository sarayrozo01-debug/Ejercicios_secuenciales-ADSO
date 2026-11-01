double segundos_ingresados, hora, minutos, segundos;

Console.Write("ingrese los segundos que desee: ");
segundos_ingresados = Convert.ToDouble(Console.ReadLine());

hora = segundos_ingresados / 3600;
minutos = (segundos_ingresados % 3600) / 60;
segundos = segundos_ingresados % 60;

Console.WriteLine($"sus segundos ingresados convertidos en horas: {hora} , minutos : {minutos} y en segundos: {segundos}");
