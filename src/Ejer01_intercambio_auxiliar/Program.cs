int A, B,Resultado;

Console.Write("ingrese el VALOR  A: ");
A = Convert.ToInt32(Console.ReadLine());

Console.Write("ingrese el VALOR  B: ");
B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("el valor original de a es: " + A + " y el valor cambiado de b es: " + B);

Resultado = A;
A = B ;
B = Resultado;

Console.WriteLine("el valor cambiado de A es: " + A + " Y el valor cambiado de B es: " + B);
