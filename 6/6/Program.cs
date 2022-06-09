/*
1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta 
la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla
*/

int columnas = 9;
int filas = 3;

int[,] carton = new int[filas, columnas];
Random aleatorio = new Random();
//Cantidad de filas
int lengthFilas = carton.GetUpperBound(0) + 1;

//Cantidad de columnas
int lengthColumnas = carton.GetUpperBound(1) + 1;

//--------------------------------------------------------------------------------------------------------------------

//primera columna 
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 0] = aleatorio.Next(1, 9);
}
//segunda
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 1] = aleatorio.Next(10, 19);
}
//tercera
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 2] = aleatorio.Next(20, 29);
}
//cuarta
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 3] = aleatorio.Next(30, 39);
}
//quinta
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 4] = aleatorio.Next(40, 49);
}
//sexta
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 5] = aleatorio.Next(50, 59);
}
//septima
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 6] = aleatorio.Next(60, 69);
}
//octava
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 7] = aleatorio.Next(70, 79);
}
//novena
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 8] = aleatorio.Next(80, 89);
}
//--------------------------------------------------------------------------------------------------------------------
//espacios en blanco
for (int i = 0; i < 3; i++)
{
    int auxi1 = aleatorio.Next(0, 8);
    int auxi2 = aleatorio.Next(0, 8);
    int auxi3 = aleatorio.Next(0, 8);
    int auxi4 = aleatorio.Next(0, 8);    
    for (int a = 0; a < 1; a++)
    {
        do
        {
            if (auxi1 == auxi2 || auxi1 == auxi3 || auxi1 == auxi4)
            {
                auxi1 = aleatorio.Next(0, 8);
            }
            if (auxi2 == auxi3 || auxi2 == auxi4)
            {
                auxi2 = aleatorio.Next(0, 8);
            }
            if (auxi3 == auxi4)
            {
                auxi3 = aleatorio.Next(0, 8);
            }
            else
            {
                break;
            }
        }
        while (auxi1 == auxi2 || auxi1 == auxi3 || auxi1 == auxi4 || auxi2 == auxi3 || auxi2 == auxi4 || auxi3 == auxi4);
        carton[i, auxi1] = 0;
        carton[i, auxi2] = 0;
        carton[i, auxi3] = 0;
        carton[i, auxi4] = 0;
    }
}
//--------------------------------------------------------------------------------------------------------------------
Console.WriteLine("---------------------------------------------------");
for (int i = 0; i < lengthFilas; i++)
{
    for (int j = 0; j < lengthColumnas; j++)
    {
        Console.Write(carton[i, j] + " || ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------------------------------");
