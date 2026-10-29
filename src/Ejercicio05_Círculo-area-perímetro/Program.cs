double radio, area, perimetro;

Console.Write("ingrese el radio del circulo: ");
radio = Convert.ToInt32(Console.ReadLine());

area = (3.1415 * radio) / 2;
perimetro = 2 * (radio * 3.1415);

Console.WriteLine("el area es de: " + area + " y el perimetor es de: " + perimetro);
