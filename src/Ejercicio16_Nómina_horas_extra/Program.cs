
double horas_trabajadas, valor_hora, salario_base, horas_extra, pago_extras, total_salario;


Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
horas_trabajadas = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de la hora ordinaria: ");
valor_hora = Convert.ToDouble(Console.ReadLine());


salario_base = 160 * valor_hora;
horas_extra = horas_trabajadas - 160;
pago_extras = horas_extra * valor_hora * 1.25;
total_salario = salario_base + pago_extras;

Console.WriteLine("Salario Base: $" + salario_base + " | Pago de Extras: $" + pago_extras + " | Total a Pagar: $" + total_salario);
