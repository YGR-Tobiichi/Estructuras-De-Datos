
Pila<char> pila;
bool correcta = true;
string cadena = "";
Console.WriteLine("Ingrese una expresion matematica:");
cadena = Console.ReadLine();
pila = new Pila<char>(cadena.Length);

for (int i = 0; i < cadena.Length; i++)
{
    if (cadena[i] == '(' || cadena[i] == '[' || cadena[i] == '{')
    {
        pila.Push(cadena[i]);
    }
    else if (!pila.Vacia)
    {
        if (cadena[i] == ')' || cadena[i] == ']' || cadena[i] == '}')
        {
            if (cadena[i] == ')')
            {
                if (pila.LeerUltimo() == '(')
                    pila.Pop();
                else
                {
                    Console.WriteLine("La expresión no está bien escrita");
                    i = cadena.Length;
                    correcta = false;
                }
            }
            else if (cadena[i] == ']')
            {
                if (pila.LeerUltimo() == '[')
                    pila.Pop();
                else
                {
                    Console.WriteLine("La expresión no está bien escrita");
                    i = cadena.Length;
                    correcta = false;
                }
            }
            else if (pila.LeerUltimo() == '{')
            {
                pila.Pop();
            }
            else
            {
                Console.WriteLine("La expresión no está bien escrita");
                i = cadena.Length;
                correcta = false;
            }
        }
    }
}
if (!pila.Vacia)
{
    correcta = false;
    Console.WriteLine("La expresión no está bien escrita");
}
if (correcta)
{
    Console.WriteLine("La expresión está bien escrita");
}
Console.ReadKey();