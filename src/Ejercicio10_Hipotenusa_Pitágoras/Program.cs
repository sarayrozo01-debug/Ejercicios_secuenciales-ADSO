double cateto_opuesto, cateto_adyasente, hipotenusa;

Console.Write("ingrese el cateto opuesto de su triangulo rectangulo: ");
cateto_opuesto = Convert.ToDouble(Console.ReadLine());

Console.Write("ingrese el cateto adyasente de su triangulo rectangulo: ");
cateto_adyasente = Convert.ToDouble(Console.ReadLine());

hipotenusa = Math.Sqrt(Math.Pow(cateto_opuesto,2)+Math.Pow(cateto_adyasente,2));

Console.WriteLine("la hipotenusa de su triangulo rectangulo es: " + hipotenusa);
