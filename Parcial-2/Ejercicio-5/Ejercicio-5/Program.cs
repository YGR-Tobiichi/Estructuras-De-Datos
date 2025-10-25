internal class Program
    {
        static void Main(string[] args)
        {
            ColaEstaticaNodo<string> cola;
            string strValor;
            int intTamaño, intValor;
            Console.Write("Ingrese el tamaño de la cola: ");
            intTamaño = int.Parse(Console.ReadLine());
            cola = new ColaEstaticaNodo<string>(intTamaño);

            for (int i = 0; i < intTamaño; i++)
            {
                Console.WriteLine("Ingrese un valor.");
                strValor = Console.ReadLine();
                cola.Encolar(strValor);
            }
            Console.WriteLine(cola.DesencolarTodo());
            Console.ReadKey();
        }
    }