// numero random
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
//ingreso
Console.WriteLine("Intente adivinar el numero del 1 al 21. ingrese a continuacion");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("Su numero ingresado es: " + numero);

var contador = 0;
// si es correcto


while (numeroSecreto < numero || numeroSecreto > numero)
{
    if (numeroSecreto > numero)
    {
        Console.WriteLine("Su numero es muy chico intente de nuevo");
        
    }
    else if (numero > 21)
    {
        Console.WriteLine("Numero ingresado no valido intente de nuevo");
        
    }else
    {
        Console.WriteLine("Su numero es muy grande intente de nuevo");
    }
    numero = int.Parse(Console.ReadLine());
    contador++;
}
if (numeroSecreto == numero)
{
    contador++;
    Console.WriteLine("Felicitaciones, has adivinado el numero secreto que era: " + numeroSecreto + ", Lo has logrado en " + contador + " intentos!!");
}