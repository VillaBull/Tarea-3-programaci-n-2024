int num1, num2, num3;
string mayor;
try
{
    Console.Write("ingrese numero numero 1: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("ingrese numero numero 2: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("ingrese numero numero 3: ");
    num3 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2 && num1 > num3)
    {
        mayor = ("El mayor es: " + num1);
    }
    else if (num2 > num1 && (num2 > num3))
    {
        mayor = ("el mayor es: " + num2);
    }
    else
    {
        mayor = ("el mayor es : " + num3);
    }

    Console.WriteLine(mayor);
    Console.ReadLine();
}

catch (FormatException)
{
    Console.WriteLine("ERROR 001 debes ingresar un numero válido: ");
}


Console.ReadKey();