internal class Program
{
    private static void Main(string[] args)
    {
        int numContraseñas=default;
        Password[] contraseñas = new Password[0];
        bool[] fuerza = new bool[0];
        int longitud = default;

        Console.WriteLine("Cuantas contraseñas quieres generar?");
        numContraseñas = int.Parse(Console.ReadLine());

        Console.WriteLine("De que tamaño?");
        longitud = int.Parse(Console.ReadLine());

        Array.Resize(ref contraseñas, numContraseñas);
        Array.Resize(ref fuerza, numContraseñas);

        for(int i = 0; i < contraseñas.Length; i++)
        {
            contraseñas[i] = new Password(longitud);
            fuerza[i] = contraseñas[i].EsFuerte(contraseñas[i].GetContraseña());
            Console.WriteLine(contraseñas[i].GetContraseña()+" "+fuerza[i].ToString());
        }
    }
}