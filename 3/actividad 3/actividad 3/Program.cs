/*
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
*/
int contador = 11;
int acumulador = 0;
int [] numeros = new int[10];
Console.WriteLine($"Por favor ingrese 10 numeros");
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
    acumulador = acumulador + numeros[i];
    
}

int mayor, menor;
mayor = numeros[0];
menor = numeros[0];


for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];

    }
    if (numeros[i] < menor)
    {
        menor = numeros[i];

    }
    
}


Console.Write("Los numeros ingresados son: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("");
Console.WriteLine($"la suma de sus numeros es: {acumulador}");
Console.WriteLine($"El promedio es: {acumulador / 10}");
Console.WriteLine($"El numero mayor es: {mayor}");
Console.WriteLine($"EL numero menor es: {menor}");
