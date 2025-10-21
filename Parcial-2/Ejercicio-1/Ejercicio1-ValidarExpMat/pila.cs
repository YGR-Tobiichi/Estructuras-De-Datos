public class Pila<Tipo>
{
    private int Max;
    private int top;
    private Tipo[] Arreglo;

    public Pila(int tamaño)
    {
        Max = tamaño - 1;
        top = -1;
        Arreglo = new Tipo[tamaño];
    }
    public bool Vacia
    {
        get
        {
            if (top == -1)
                return true;
            else
                return false;
        }
    }
    public bool Llena
    {
        get { return top == Max; }
    }
    public void Push(Tipo dato)
    {
        if (!Llena)
        {
            top++;
            Arreglo[top] = dato;
        }
    }
    public Tipo Pop()
    {
        if (!Vacia)
        {
            Tipo dato = Arreglo[top];
            top--;
            return dato;
        }
        else
            throw new Exception("Pila vacia");
    }
    public Tipo LeerUltimo()
    {
        if (!Vacia)
            return Arreglo[top];
        else
            throw new Exception("Pila vacia");
    }
}