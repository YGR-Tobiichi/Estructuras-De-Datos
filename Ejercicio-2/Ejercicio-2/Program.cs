Pila<char> pila;
string cadena = "", cadenaInv = "";

Console.WriteLine("Ingrese una palabra");
cadena = Console.ReadLine();
pila = new Pila<char>(cadena.Length);

for (int i = 0; i < cadena.Length; i++)
{
    char c = cadena[i];
    pila.Push(c);
}
while (!pila.Vacia)
{
    char c = pila.Pop();
    cadenaInv += c;
}

Console.WriteLine(cadenaInv);
if (cadena == cadenaInv)
    Console.WriteLine("Es palindromo");
else
    Console.WriteLine("No es palindromo");