Double base1, altura1, area, perimetro;

Console.Write("ingrese la  base de su rectangulo: ");
base1 = Convert.ToDouble(Console.ReadLine());

Console.Write("ingrese la altura del rectangunlo: ");
altura1 = Convert.ToDouble(Console.ReadLine());

area = base1 * altura1;
perimetro = 2 * (base1 + altura1);

Console.WriteLine("el area es de: " + area + " y el perimetro es de: " + perimetro);

area = (base1 * 2) * (altura1 * 3);

Console.WriteLine("el area con su base duplicada y altura triplicada es de: " + area);
