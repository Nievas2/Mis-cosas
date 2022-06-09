/*
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

//columnas son alumnos
Console.WriteLine("Ingrese la cantidad de columnas");
int cantidadColumnas = int.Parse(Console.ReadLine());

//filas son notas
Console.WriteLine("Ingrese la cantidad de filas");
int cantidadFilas = int.Parse(Console.ReadLine());

//matriz
int [,] numeros = new int[cantidadFilas, cantidadColumnas];





//Cantidad de filas
int lengthFilas = numeros.GetUpperBound(0) + 1;

//Cantidad de columnas
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//Recorro la matriz para su carga

for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    Console.WriteLine("");
    Console.WriteLine($"Ingrese las notas del alumno N°{columnas + 1}");
    for (int filas = 0; filas < lengthFilas; filas++)
    {
        Console.WriteLine($"Nota N°{filas + 1}");
        numeros[filas, columnas] = int.Parse(Console.ReadLine());
    }
}

//Recorro la matriz para su muestra

for (int columnas = 0; columnas < lengthColumnas; columnas++)
{

    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N°{columnas + 1}: ");

    // Recorremos filas
    for (int filas = 0; filas < lengthFilas; filas++)
    {
        Console.Write($"La nota N° {filas + 1}: ");
        Console.WriteLine(numeros[filas, columnas]);
    }
}
//Console.WriteLine("ingrese cantidad de promedios");

//double cantidadPromedios = double.Parse(Console.ReadLine());

//vector
double [] promedios = new double[cantidadColumnas];

//Calculo el promedio de cada columna
double acumulador = 0;  
for (int posicion = 0; posicion < lengthColumnas; posicion++)
{
    for (int i = 0; i < promedios.Length; i++)
    {
        Console.WriteLine($"El promedio del alumno N°{posicion + 1} es: {promedios[i]}");
        acumulador = acumulador + promedios[i];
        Console.WriteLine($"El promedio del alumno N°{posicion + 1} es: {acumulador}");
    }




}
