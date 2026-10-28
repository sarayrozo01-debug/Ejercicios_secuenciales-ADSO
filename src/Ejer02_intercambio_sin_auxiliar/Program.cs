int A, B;

Console.Write("ingrese el primer numero: ");
A = Convert.ToInt32(Console.ReadLine());

Console.Write("ingrese el segundo numero: ");
B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("los numero originales sin cambiar de a y b son: "+A +" , "+B);

A = A + B;
B = A - B;
A = A - B;

Console.WriteLine(" Los numeros cambiados de a y b son: "+A +" , "+B);
