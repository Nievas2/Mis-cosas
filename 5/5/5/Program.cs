/*
1)Pedir al usuario la longitud de un vector
2)Crear el vector del tamaño ingresado.
3)Llenar el mismo con datos aleatorios
4)Mostrar el vector por pantalla
5)Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo 
y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe 
quedar así: 50, 40, 30, 20, 10.  Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. 
Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
6)Mostrar el vector nuevamente. 
*/

//ingreso
Console.WriteLine("Por favor ingrese la longitud del vector");
int tamaño = int.Parse(Console.ReadLine());
int [] vector = new int[tamaño];


//randomizar numero
Random aleatorio = new Random();
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorio.Next(100);
}


//mostrar vector
for (int i = 0; i < vector.Length; i++)
{
    Console.Write($"{vector[i]} ");
}
Console.WriteLine();
Console.WriteLine("------------------------------");

//cambiar vector al reves
int mitad = tamaño / 2;
int contador = 0;
for (int ia = vector.Length - 1; mitad > 0; ia--)
{
    int auxiliar = 0;
    int auxiliar2 = 0;
    tamaño--;
    auxiliar = vector[tamaño];
    auxiliar2 = vector[contador];
    vector[contador] = auxiliar;
    vector[tamaño] = auxiliar2;
    contador++;
    mitad--;
}

//mostrar vector 
foreach (var item in vector)
{
    Console.Write(item + " ");
}
