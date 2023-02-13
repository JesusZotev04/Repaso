internal class Program
{
    private static void Main(string[] args)
    {
        Password[] contrasenyas;
        bool[] esFuerte;
        int longitudContrasenya = default, cantidadContrasenyas = default;

        Console.Write("¿Cuántas contraseñas quieres introducir?: ");
        cantidadContrasenyas = int.Parse(Console.ReadLine() ?? "0");

        contrasenyas = new Password[cantidadContrasenyas];
        esFuerte = new bool[cantidadContrasenyas];

        Console.WriteLine("");
        for (int i = 0; i < contrasenyas.Length; i++) {
            // Pedir datos
            Console.Write($"Contraseña ({i+1}). Longitud: ");
            longitudContrasenya = int.Parse(Console.ReadLine() ?? "0");
            // Guardar contrasenya
            contrasenyas[i] = new Password(longitudContrasenya);
            contrasenyas[i].GenerarPassword(contrasenyas[i].GetLongitud());
            // Guardar si es fuerte o no. E imprimirlo en pantalla
            esFuerte[i] = contrasenyas[i].EsFuerte(contrasenyas[i].GetConstranya());
            Console.WriteLine($"{contrasenyas[i].GetConstranya()} {esFuerte[i]}");
        }


    }
}