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

//Validar Edad para ingresar a un club 

int mayoria, resta;
Console.WriteLine("Bienvenido al Club Adultos y más");
Console.WriteLine("A Continuación se solicitará el dato de su edad");
Console.Write("Por Favor Ingrese su Edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Puede ingresar, sea usted bienvenido; y recuerde, lo que pasa en el club, se queda en el club");
}
else
{
    Console.WriteLine("Lo sentimos, usted no puede ingresar, no es mayor de edad");
    resta = 18 - edad;
    Console.WriteLine("Usted solo tiene: " + edad );
    Console.WriteLine("le faltan: " + resta + " años para poder ingresar");
}


Console.ReadKey();