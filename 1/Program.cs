//inicio
Console.WriteLine("Actividad N°1");
Console.Clear();
Console.WriteLine("Ingrese su nombre");
string nombre;
nombre = Console.ReadLine();
Console.WriteLine("¡Hola " + nombre + "!");
Console.WriteLine("¿Usted desea continua? S/N");
string respuesta = Console.ReadLine(); 

//bucle y condiciones
while (respuesta.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre");
    string nombre2 = Console.ReadLine();
    Console.WriteLine("¡Hola " + nombre2 + "!");
    Console.WriteLine("¿Usted desea continua? S/N");
    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}
    
