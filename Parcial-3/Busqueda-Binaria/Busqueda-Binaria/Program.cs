using System.Globalization;

Random random = new Random();
int[] arr = { 1, 2, 3, 4 , 5 , 6, 7};
int objetivo = 2;
Console.WriteLine($"Buscando el número {objetivo}...");
int resultado = Buscar(arr, objetivo);
Console.WriteLine(resultado);
Console.ReadKey();

static int Buscar(int[] arr, int num)
{
    int i = 0, f = arr.Length - 1, posicion = -1;
    while (i <= f)
    {
        int m = i + (f - i) / 2;
        if (arr[m] == num)
        {
            posicion = arr[m];
            i = f;
        }
        else if (num > arr[m])
        {
            i = m + 1;
        }
        else
        {
            f = m - 1;
        }
    }
    return posicion;
}