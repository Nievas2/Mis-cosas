int columnas = 9;
int filas = 3;

int[,] carton = new int[filas, columnas];
Random aleatorio = new Random();
//Cantidad de filas
int lengthFilas = carton.GetUpperBound(0) + 1;

//Cantidad de columnas
int lengthColumnas = carton.GetUpperBound(1) + 1;
string respuesta;
do
{
//--------------------------------------------------------------------------------------------------------------------
//generamos y hacemos que los numeros no se repitan
//primera columna 
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 0] = aleatorio.Next(1, 9);
    do
    {
        if (carton[0, 0] == carton[1, 0])
        {
            carton[0, 0] = aleatorio.Next(1, 9);
        }
        if (carton[1, 0] == carton[2, 0])
        {
            carton[1, 0] = aleatorio.Next(1, 9);
        }
        if (carton[0, 0] == carton[2, 0])
        {
            carton[2, 0] = aleatorio.Next(1, 9);
        }
        if (carton[0, 0] != carton[2, 0] && carton[1, 0] != carton[2, 0] && carton[0, 0] != carton[2, 0])
        {
            break;
        }
    } while (carton[0, 0] == carton[2, 0] || carton[1, 0] == carton[2, 0] || carton[0, 0] == carton[2, 0]);
}
//segunda
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 1] = aleatorio.Next(10, 19);
        do
        {
            if (carton[0, 1] == carton[1, 1])
            {
                carton[0, 1] = aleatorio.Next(10, 19);
            }
            if (carton[1, 1] == carton[2, 1])
            {
                carton[1, 1] = aleatorio.Next(10, 19);
            }
            if (carton[0, 1] == carton[2, 1])
            {
                carton[2, 1] = aleatorio.Next(10, 19);
            }
            if (carton[0, 1] != carton[2, 1] && carton[1, 1] != carton[2, 1] && carton[0, 1] != carton[2, 1])
            {
                break;
            }
        } while (carton[0, 1] == carton[2, 1] || carton[1, 1] == carton[2, 1] || carton[0, 1] == carton[2, 1]);
    }
//tercera
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 2] = aleatorio.Next(20, 29);
        do
        {
            if (carton[0, 2] == carton[1, 2])
            {
                carton[0, 2] = aleatorio.Next(20, 29);
            }
            if (carton[1, 2] == carton[2, 2])
            {
                carton[1, 2] = aleatorio.Next(20, 29);
            }
            if (carton[0, 2] == carton[2, 2])
            {
                carton[2, 2] = aleatorio.Next(20,29);
            }
            if (carton[0, 2] != carton[2, 2] && carton[1, 2] != carton[2, 2] && carton[0, 2] != carton[2, 2])
            {
                break;
            }
        } while (carton[0, 2] == carton[2, 2] || carton[1, 2] == carton[2, 2] || carton[0, 2] == carton[2, 2]);
    }
//cuarta
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 3] = aleatorio.Next(30, 39);
        do
        {
            if (carton[0, 3] == carton[1, 3])
            {
                carton[0, 3] = aleatorio.Next(30, 39);
            }
            if (carton[1, 3] == carton[2, 3])
            {
                carton[1, 3] = aleatorio.Next(30, 39);
            }
            if (carton[0, 3] == carton[2, 3])
            {
                carton[2, 3] = aleatorio.Next(30, 39);
            }
            if (carton[0, 3] != carton[2, 3] && carton[1, 3] != carton[2, 3] && carton[0, 3] != carton[2, 3])
            {
                break;
            }
        } while (carton[0, 3] == carton[2, 3] || carton[1, 3] == carton[2, 3] || carton[0, 3] == carton[2, 3]);
    }
//quinta
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 4] = aleatorio.Next(40, 49);
        do
        {
            if (carton[0, 4] == carton[1, 4])
            {
                carton[0, 4] = aleatorio.Next(40, 49);
            }
            if (carton[1, 4] == carton[2, 4])
            {
                carton[1, 4] = aleatorio.Next(40, 49);
            }
            if (carton[0, 4] == carton[2, 4])
            {
                carton[2, 4] = aleatorio.Next(10, 49);
            }
            if (carton[0, 4] != carton[2, 4] && carton[1, 4] != carton[2, 4] && carton[0, 4] != carton[2, 4])
            {
                break;
            }
        } while (carton[0, 4] == carton[2, 4] || carton[1, 4] == carton[2, 4] || carton[0, 4] == carton[2, 4]);
    }
//sexta
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 5] = aleatorio.Next(50, 59);
        do
        {
            if (carton[0, 5] == carton[1, 5])
            {
                carton[0, 5] = aleatorio.Next(50, 59);
            }
            if (carton[1, 5] == carton[2, 5])
            {
                carton[1, 5] = aleatorio.Next(50, 59);
            }
            if (carton[0, 5] == carton[2, 5])
            {
                carton[2, 5] = aleatorio.Next(50, 59);
            }
            if (carton[0, 5] != carton[2, 5] && carton[1, 5] != carton[2, 5] && carton[0, 5] != carton[2, 5])
            {
                break;
            }
        } while (carton[0, 5] == carton[2, 5] || carton[1, 5] == carton[2, 5] || carton[0, 5] == carton[2, 5]);
    }
//septima
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 6] = aleatorio.Next(60, 69);
        do
        {
            if (carton[0, 6] == carton[1, 6])
            {
                carton[0, 6] = aleatorio.Next(60, 69);
            }
            if (carton[1, 6] == carton[2, 6])
            {
                carton[1, 6] = aleatorio.Next(60, 69);
            }
            if (carton[0, 6] == carton[2, 6])
            {
                carton[2, 6] = aleatorio.Next(60, 69);
            }
            if (carton[0, 6] != carton[2, 6] && carton[1, 6] != carton[2, 6] && carton[0, 6] != carton[2, 6])
            {
                break;
            }
        } while (carton[0, 6] == carton[2, 6] || carton[1, 6] == carton[2, 6] || carton[0, 6] == carton[2, 6]);
    }
//octava
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 7] = aleatorio.Next(70, 79);
        do
        {
            if (carton[0, 7] == carton[1, 7])
            {
                carton[0, 7] = aleatorio.Next(70, 79);
            }
            if (carton[1, 7] == carton[2, 7])
            {
                carton[1, 7] = aleatorio.Next(70, 79);
            }
            if (carton[0, 7] == carton[2, 7])
            {
                carton[2, 7] = aleatorio.Next(70, 79);
            }
            if (carton[0, 7] != carton[2, 7] && carton[1, 7] != carton[2, 7] && carton[0, 7] != carton[2, 7])
            {
                break;
            }
        } while (carton[0, 7] == carton[2, 7] || carton[1, 7] == carton[2, 7] || carton[0, 7] == carton[2, 7]);
    }
//novena
for (int fila = 0; fila < lengthFilas; fila++)
{
    carton[fila, 8] = aleatorio.Next(80, 89);
        do
        {
            if (carton[0, 8] == carton[1, 8])
            {
                carton[0, 8] = aleatorio.Next(80, 89);
            }
            if (carton[1, 8] == carton[2, 8])
            {
                carton[1, 8] = aleatorio.Next(80, 89);
            }
            if (carton[0, 8] == carton[2, 8])
            {
                carton[2, 8] = aleatorio.Next(80, 89);
            }
            if (carton[0, 8] != carton[2, 8] && carton[1, 8] != carton[2, 8] && carton[0, 8] != carton[2, 8])
            {
                break;
            }
        } while (carton[0, 8] == carton[2, 8] || carton[1, 8] == carton[2, 8] || carton[0, 8] == carton[2, 8]);
    }
    //espacios en blanco
    int auxi1;
int auxi2;
int auxi3;
int auxi4;
int contador = 0;
    int auxi5 = 0;
    int auxi6 = 0;
    int auxi7 = 0;
    int auxi8 = 0;
    for (int i = 0; i < 2; i++)
{
    contador++;
    auxi1 = aleatorio.Next(0, 8);
    auxi2 = aleatorio.Next(0, 8);
    auxi3 = aleatorio.Next(0, 8);
    auxi4 = aleatorio.Next(0, 8);
    for (int a = 0; a < 1; a++)
    {
        do
        {
            if (auxi1 == auxi2 || auxi1 == auxi3 || auxi1 == auxi4)
            {
                auxi1 = aleatorio.Next(0, 9);
            }
            if (auxi2 == auxi3 || auxi2 == auxi4)
            {
                auxi2 = aleatorio.Next(0, 9);
            }
            if (auxi3 == auxi4)
            {
                auxi3 = aleatorio.Next(0, 9);
            }
            if (auxi1 != auxi2 && auxi1 != auxi3 && auxi1 != auxi4 && auxi2 != auxi3 && auxi2 != auxi4 && auxi3 != auxi4)
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
    if (contador == 2)
    {
        for (
                int a = 0; a < 1; a++)
        {
            auxi5 = aleatorio.Next(0, 9);
            auxi6 = aleatorio.Next(0, 9);
            auxi7 = aleatorio.Next(0, 9);
            auxi8 = aleatorio.Next(0, 9);
            do
            {
                if (auxi5 == auxi2 || auxi5 == auxi3 || auxi5 == auxi4 || auxi5 == auxi1 || auxi5 == auxi6 || auxi5 == auxi7 || auxi5 == auxi8)
                {
                    auxi5 = aleatorio.Next(0, 9);
                }
                if (auxi6 == auxi3 || auxi6 == auxi4 || auxi6 == auxi1 || auxi6 == auxi2 || auxi6 == auxi7 || auxi6 == auxi8)
                {
                    auxi6 = aleatorio.Next(0, 9);
                }
                if (auxi7 == auxi4 || auxi7 == auxi2 || auxi7 == auxi3 || auxi7 == auxi1 || auxi7 == auxi8)
                {
                    auxi7 = aleatorio.Next(0, 9);
                }
                if (auxi8 == auxi1 || auxi8 == auxi2 || auxi8 == auxi3 || auxi8 == auxi4)
                {
                        auxi8 = aleatorio.Next(0, 9);
                }
                {

                }
                if (auxi5 != auxi6 && auxi5 != auxi7 && auxi5 != auxi8 && auxi5 != auxi1 && auxi5 != auxi2 && auxi5 != auxi3 && auxi5 != auxi4 &&
                    auxi6 != auxi7 && auxi6 != auxi8 && auxi6 != auxi1 && auxi6 != auxi2 && auxi6 != auxi3 && auxi6 != auxi4
                && auxi7 != auxi1 && auxi7 != auxi2 && auxi7 != auxi3 && auxi7 != auxi4 && auxi7 != auxi8 && auxi8 != auxi1 && auxi8 != auxi2 
                && auxi8 != auxi3 && auxi8 != auxi4)
                {
                    break;
                }
            } while (auxi5 == auxi6 || auxi5 == auxi7 || auxi5 == auxi8 || auxi5 == auxi1 || auxi5 == auxi2 || auxi5 == auxi3 || auxi5 == auxi4 ||
                    auxi6 == auxi7 || auxi6 == auxi8 || auxi6 == auxi1 || auxi6 == auxi2 || auxi6 == auxi3 || auxi6 == auxi4
                || auxi7 == auxi1 || auxi7 == auxi2 || auxi7 == auxi3 || auxi7 == auxi4 || auxi7 == auxi8 || auxi8 == auxi1 || auxi8 == auxi2
                || auxi8 == auxi3 || auxi8 == auxi4);
            carton[2, auxi5] = 0;
            carton[2, auxi6] = 0;
            carton[2, auxi7] = 0;
            carton[2, auxi8] = 0;
        }
    }
}
//aca se muestra todo el carton
Console.WriteLine("---------------------------------------------------");

for (int i = 0; i < lengthFilas; i++)
{
    for (int j = 0; j < lengthColumnas; j++)
    {
        if (carton[i, j] == 0)
        {
            Console.Write("  ||");
        }
        else
        {
            Console.Write(" " + carton[i, j] + "||");
        }
    }
    Console.WriteLine();
}
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("Desea generar otro carton? (s/n)");
    respuesta = Console.ReadLine();
    if (respuesta.ToUpper()== "N")
    {
        Console.WriteLine("Gracias por usar el programa");
    }
    if (respuesta.ToUpper() == "S")
    {
        Console.WriteLine("Aqui vamos");
    }
} while (respuesta.ToUpper() == "S");