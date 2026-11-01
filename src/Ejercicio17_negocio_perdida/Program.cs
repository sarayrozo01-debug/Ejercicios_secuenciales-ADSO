double costo_fabricacion, precio_venta, unidades_vendidas, costo_total, ingresos_totales, ganancia_total, porcentaje_rentabilidad;

Console.Write("Ingrese el costo de fabricación por unidad: ");
costo_fabricacion = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el precio de venta por unidad: ");
precio_venta = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la cantidad de unidades vendidas: ");
unidades_vendidas = Convert.ToDouble(Console.ReadLine());

costo_total = costo_fabricacion * unidades_vendidas;
ingresos_totales = precio_venta * unidades_vendidas;
ganancia_total = ingresos_totales - costo_total;
porcentaje_rentabilidad = (ganancia_total / costo_total) * 100;

Console.WriteLine("Ganancia Total: $" + ganancia_total + ",  Rentabilidad: " + porcentaje_rentabilidad + "%");
