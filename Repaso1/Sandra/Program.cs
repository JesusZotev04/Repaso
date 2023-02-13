    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de contraseñas a generar:");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int longitud = 8;

            Password[] passwords = new Password[n];
            bool[] fuertes = new bool[n];

            for (int i = 0; i < n; i++)
            {
                passwords[i] = new Password(longitud);
                fuertes[i] = passwords[i].esFuerte();
            }

            Console.WriteLine("\nContraseñas generadas:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(passwords[i].contraseña + " " + fuertes[i]);
            }

            Console.ReadLine();
        }
    }
