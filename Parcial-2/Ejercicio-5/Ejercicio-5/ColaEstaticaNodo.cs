public class ColaEstaticaNodo<Tipo>
{
    private readonly int Max;
        private int Frente;
        private int Final;
        private Nodo<Tipo>[] Cola;

        public ColaEstaticaNodo(int Tamaño)
        {
            Max = Tamaño;
            Frente = -1;
            Final = -1;
            Cola = new Nodo<Tipo>[Max];
        }

        private bool DetectarColaLlena()
        {
            if (Final == Max - 1)
                return true;
            else
                return false;
        }
        private bool DetectarColaVacia()
        {
            if (Frente == Final)
                return true;
            else
                return false;
        }
        public bool Encolar(Tipo Valor)
        {
            if (!DetectarColaLlena())
            {
                Final++;
                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.Dato = Valor;
                Cola[Final] = nuevoNodo;
                return true;
            }
            else
                return false;
        }
        public Tipo Desencolar()
        {
            if (!DetectarColaVacia())
            {
                Frente++;
                Nodo<Tipo> nodoDesencolado = Cola[Frente];
                Cola[Frente] = default;
                return nodoDesencolado.Dato;
            }
            else
                return default;
        }
        public string DesencolarTodo()
        {
            string strResultado = "\n";
            while (!DetectarColaVacia())
            {
                Nodo<Tipo> nodoDesencolado = new Nodo<Tipo>();
                nodoDesencolado.Dato = this.Desencolar();
                strResultado += "Sale " + (Frente+1) + " " + nodoDesencolado.Dato + "\n";
            }
            return strResultado;
        }
}