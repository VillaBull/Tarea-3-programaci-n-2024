using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;

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

int  resta;

while (true)
{
    try
    {
        Console.WriteLine("Bienvenido al Club Adultos y más");
        Console.WriteLine("A Continuación se solicitará el dato de su edad");
        Console.Write("Por Favor Ingrese su Edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Puede ingresar, sea usted bienvenido; y recuerde, lo que pasa en el club, se queda en el club");
            break;
        }
        else
        {
            Console.WriteLine("Lo sentimos, usted no puede ingresar, no es mayor de edad");
            resta = 18 - edad;
            Console.WriteLine("Usted solo tiene: " + edad);
            Console.WriteLine("le faltan: " + resta + " años para poder ingresar");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("El Dato que ingresaste no es valido, ingresa un numero entero");
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
}



//Precio final de un producto
double preciofinal, descuento;

try
{
    Console.WriteLine("Ingrese el precio del Producto: ");
    double precio = double.Parse(Console.ReadLine());

    if (precio > 100)
    {
        descuento = precio * 0.10;
        preciofinal = precio - descuento;
    }
    else
    {
        preciofinal = precio;
    }

    Console.WriteLine($"el precio es: {preciofinal}");
}
catch (FormatException)
{
    Console.WriteLine("El Dato que ingresaste no es valido");
}
catch (Exception ex)
{
    Console.WriteLine("ERROR: " + ex.Message);
}

//Credenciales

string usuario = "Ingenieria";
string contraseña = "Sistemas";

while (true)
{
    try
    {
        Console.WriteLine("ingrese usuario: ");
        usuario = Console.ReadLine();

        Console.WriteLine("ingrese contraseña: ");
        contraseña = Console.ReadLine();

        if (usuario == "Ingenieria" && contraseña == "Sistemas")
        {
            Console.WriteLine("Credenciales Correctas, Bienvenido");
            break;
        }
        else
        {
            Console.WriteLine("ACCESO DENEGADO, usuario o contraseña incorrecto");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR" + ex.Message);
    }
}

//Numero par e impar

int numero;

try
{
    Console.WriteLine("ingrese un numero entero: ");
    numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("Es par");
    }
    else
    {
        Console.WriteLine("Es impar");
    }
}
catch (FormatException)
{
    Console.WriteLine("Ingrese un numero entero");
}
catch (OverflowException)
{
    Console.WriteLine("ERROR");
}

//Prestamo

int monto, año;

try
{
    Console.WriteLine("Ingrese monto a solicitar de su prestamo: ");
    monto = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su edad: ");
    año = int.Parse(Console.ReadLine());

    if (monto < 5000 || año > 60)
    {
        Console.WriteLine("Crédito Aprobado");
    }
    else
    {
        Console.WriteLine("Crédito Denegado");
    }
}
catch (FormatException)
{
    Console.WriteLine("El Dato que ingresaste no es valido");
}
catch (Exception ex)
{
    Console.WriteLine("ERROR: " + ex.Message);
}

// areas figuras geometricas
float cuadrado, triangulo, circulo, superficie, altura, radio;
string eleccion;


Console.WriteLine("A continuación se presenta una lista de figuras geometricas");
Console.WriteLine("Escoge la figura de tu interés para calcular el área");
Console.ReadLine();

bool seguir = true;
while (seguir)
{
    Console.WriteLine("1.Cuadrado");
    Console.WriteLine("2.Triangulo");
    Console.WriteLine("3.Circulo");
    Console.WriteLine("4.Ninguna de las anteriores");

    Console.WriteLine("elige: ");
    eleccion = Console.ReadLine();
    switch (eleccion)
    {
        case "1":
            Console.WriteLine("ingrese la base: ");
            superficie = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese altura: ");
            altura = Convert.ToSingle(Console.ReadLine());

            cuadrado = superficie * altura;

            Console.WriteLine($"El área del cuadrado es: {cuadrado}");
            Console.ReadLine();
            break;
        case "2":
          
            Console.WriteLine("ingrese la base: ");
            superficie = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese altura: ");
            altura = Convert.ToSingle(Console.ReadLine());

            triangulo = (superficie * altura) / 2;

            Console.WriteLine($"El área del triangulo es: {triangulo}");
            Console.ReadLine();
            break;
        case "3":
                Console.WriteLine("ingrese el radio del circulo: ");
                radio = Convert.ToSingle(Console.ReadLine());

                circulo = (float)(Math.PI * Math.Pow(radio, 2));

                Console.WriteLine($"El área del circulo es: {circulo}");
                Console.ReadLine();
                break;
        case "4":
            seguir = false;
            break;
        default:
            Console.WriteLine("Opción no valida");
            break;
    }
}
//letras a numeros

string letras; 

Console.WriteLine("Ingrese un numero del 1 al 5, en letras");
letras = Console.ReadLine().ToLower();

switch (letras)
{
    case "uno":
        Console.WriteLine("El numero correspondiente es : 1" );
        break;
    case "dos":
        Console.WriteLine("El numero correspondiente es : 2");
        break;
    case "tres":
        Console.WriteLine("El numero correspondiente es : 3");
        break;
    case "cuatro":
        Console.WriteLine("El numero correspondiente es : 4");
        break;
    case "cinco":
        Console.WriteLine("El numero correspondiente es : 5");
        break;
    default:
        Console.WriteLine("numero invalido");
        break;
}

//dias de la semana

Console.WriteLine("Ingrese un numero del 1 al 7, para identificar en que dia de la semana estamos:");
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Lunes");
        break;
    case 3:
        Console.WriteLine("Martes");
        break;
    case 4:
        Console.WriteLine("Miercoles");
        break;
    case 5:
        Console.WriteLine("Jueves");
        break;
    case 6:
        Console.WriteLine("Viernes");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Numero inválido");
        break;
}

//Servicios
string menu;
    Console.WriteLine("1.CarWash");
    Console.WriteLine("2.Cambio de Aceite");
    Console.WriteLine("3.Revisión Mecánica");

    Console.WriteLine("elige: ");
    menu= Console.ReadLine();
    switch (menu)
    {
        case "1":
            Console.WriteLine("a.carro");
            Console.WriteLine("b.moto");
            string letra =Console.ReadLine();
            switch (letra)
            {
                case "a":
                    Console.WriteLine("Su total a pagar es de: Q30.°°");
                    break;
                case "b":
                    Console.WriteLine("El total a pagar es Q15.00");
                break;
            }
            break;
        case "2":
            Console.WriteLine("El total por cambio de aceite es: Q250");
            break;
        case "3":
            Console.WriteLine("El total por revisión mecánica es de: Q150 ");
            break;
        default:
            Console.WriteLine("Opción no valida");
            break;
    }

string idioma;
Console.WriteLine("Ingrese su idioma de preferencia:");
Console.WriteLine("1. Español");
Console.WriteLine("2. Ingles");
Console.WriteLine("3. Francés");

idioma = Console.ReadLine();

switch (idioma)
{
    case "1":
        Console.WriteLine("Bienvenido, este es el idioma español");
        break;
    case "2":
        Console.WriteLine("Welcome, this is the english language");
        break;
    case "3":
        Console.WriteLine("bienvenue, c'est la langue anglaise");
        break; 
    default:
        Console.WriteLine("Lenguaje no encontrado");
        break;
}

string  nota;
Console.WriteLine("A continuación se evaluará las notas obtenidas por un estudiante");
Console.WriteLine("Ingrese calificación de examen: ");

nota = Console.ReadLine();

    if (int.TryParse(nota, out int rango))
    {
        switch (rango)
        {
            case int num when (num >= 9 && num <= 10):
                Console.WriteLine("Dotado");
                break;
            case int num when (num == 8):
                Console.WriteLine( "Brillante");
                break;
            case int num when (num == 7):
                Console.WriteLine("Inteligente");
                break;
            case int num when (num == 6):
                Console.WriteLine("Aprobado");
                break;
            case int num when (num >= 0 && num <= 5):
                Console.WriteLine("Que te lleve la carreta primo asi legalmente mano");
                break;
            default:
                Console.WriteLine("Calificación No Válida");
                break;
        }
    }
    else
    {
        Console.WriteLine("La calificación no es un numero entero");
    }
