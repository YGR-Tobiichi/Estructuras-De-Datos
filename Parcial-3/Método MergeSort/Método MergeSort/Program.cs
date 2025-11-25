int[] arreglo = {38, 27, 43, 10};

int[] arregloOrdenado = MergeSort(arreglo);
foreach (int num in arregloOrdenado)
{
    Console.Write(num + " ");
}
Console.ReadKey();

static int[] MergeSort(int[] array)
{
    if (array.Length == 1)
    {
        return array;
    }
    int mid = array.Length / 2;
    int[] izq = new int[mid];
    int[] der = new int[array.Length - mid];

    for (int i = 0; i < izq.Length; i++)
    {
        izq[i] = array[i];
    }
    for (int j = 0; j < der.Length; j++)
    {
        der[j] = array[mid + j];
    }
    int[] IzqMs = MergeSort(izq);
    int[] DerMs = MergeSort(der);

    return Unir(IzqMs, DerMs); 
}

static int[] Unir(int[] izq, int[] der)
{
    int[] res = new int[izq.Length + der.Length];
    int i = 0, j = 0, k = 0;

    while (i < izq.Length && j < der.Length)
    {
        if (izq[i] <= der[j])
        {
            res[k] = izq[i];
            i++;
        }
        else
        {
            res[k] = der[j];
            j++;
        }
        k++;
    }

    while (i < izq.Length)
    {
        res[k] = izq[i];
        i++;
        k++;
    }
    while (j < der.Length)
    {
        res[k] = der[j];
        j++;
        k++;
    }
    return res;
}