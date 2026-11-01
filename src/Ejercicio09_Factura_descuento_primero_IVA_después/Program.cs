double subtotal, descuento, iva, total;

Console.Write("ingrese el subtotal de su factura; ");
subtotal = Convert.ToDouble(Console.ReadLine());

descuento = subtotal * 0.10;
subtotal = subtotal - descuento;
iva = subtotal * 0.19;
total = subtotal + iva;

Console.WriteLine($"su descuento fue de: {descuento}, el iva es de: {iva} y el total de su factura es de: {total}");

