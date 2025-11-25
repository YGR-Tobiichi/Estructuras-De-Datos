int[] arreglo = new int[6];
bool Cambio = true;
Console.WriteLine("Ingrese 6 números enteros:");
for (int i = 0; i < arreglo.Length; i++)
{
    Console.Write("Número {i + 1}: ");
    arreglo[i] = int.Parse(Console.ReadLine());
}

// Método de ordenamiento burbuja
for (int i = 0; i < arreglo.Length - 1; i++)
{
    if (Cambio)
        Cambio = false;
    else
        i = arreglo.Length;
    for (int j = 0; j < arreglo.Length - 1; j++)
    {
        if (arreglo[j] > arreglo[j + 1])
        {
            int temporal = arreglo[j];
            arreglo[j] = arreglo[j + 1];
            arreglo[j + 1] = temporal;
            Cambio = true;
        }
    }
}
Console.WriteLine("Arreglo ordenado: ");
for (int i = 0; i < arreglo.Length; i++)
{
    Console.WriteLine(arreglo[i]);
}
Console.ReadKey();