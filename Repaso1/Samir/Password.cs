using System.Text.RegularExpressions;
class Password
{
    private string contraseña;
    private int longitud = 8;

    public Password(string contraseña, int longitud)
    {
        this.contraseña = contraseña;
        this.longitud = contraseña.Length;
    }
    public Password(int longitud)
    {
        this.longitud = longitud;
        this.contraseña = GenerarPassword(longitud);
    }
    public bool EsFuerte(string contraseña)
    {
        char[] contraseña2 = new char[contraseña.Length];
        int numMayus = default;
        string patronMayus = @"[A-Z]";
        int numMinus = default;
        string patronMinus = @"[a-z]";
        int numNums=default;
        string patronNums = @"\d";
        bool fuerte = default;

        for(int i = 0; i < contraseña2.Length; i++)
        {
            contraseña2[i] = contraseña[i];
        }

        for(int i = 0; i < contraseña2.Length;i++)
        {
            if(Regex.IsMatch(contraseña2[i].ToString(),patronMayus))
            {
                numMayus += 1;
            }
            if(Regex.IsMatch(contraseña2[i].ToString(),patronMinus))
            {
                numMinus += 1;
            }
            if(Regex.IsMatch(contraseña2[i].ToString(),patronNums))
            {
                numNums += 1;
            }
        }

        if(numMayus > 2 && numMinus > 1 && numNums > 5)
            fuerte = true;
        else
            fuerte = false;
        return fuerte;
    }
    public string GenerarPassword(int longitud)
    {
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
        char[] contraseña = new char[longitud];
        Random semilla = new Random();
        string contraseñaFinal = default;
        
        for (int i = 0; i < contraseña.Length; i++)
        {
            contraseña[i] = caracteres[semilla.Next(0, caracteres.Length)];
        }

        for(int i = 0; i < contraseña.Length; i++)
        {
            contraseñaFinal += contraseña[i];
        }
        return contraseñaFinal;
    }

    public void SetLongitud()
    {
        this.longitud = longitud;
    }

    public string GetContraseña()
    {
        return contraseña;
    }

    public int GetLongitud()
    {
        return longitud;
    }

    public override string ToString()
    {
        return $"{contraseña} {EsFuerte(contraseña)}";
    }
}