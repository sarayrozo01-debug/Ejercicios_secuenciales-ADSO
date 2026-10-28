double nota1, nota2, nota3, nota_definitiva;

Console.Write("ingrese su nota_1: ");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ingrese su nota_2: ");
nota2 = Convert.ToInt32(Console.ReadLine());

Console.Write("ingrese su nota_3: ");
nota3 = Convert.ToInt32(Console.ReadLine());

nota_definitiva = nota1 * 0.25 + nota2 * 0.35 + nota3 * 0.40;

Console.WriteLine("su nota definiticva es: " + nota_definitiva);
