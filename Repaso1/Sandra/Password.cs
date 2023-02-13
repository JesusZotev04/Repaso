using System;
using System.Text;

    class Password
    {
        private int longitud;
        public string contraseña;

        public Password(int longitud, string contraseña)
        {
            this.longitud = 8;
            this.contraseña = contraseña;
        }
        public int GetLongitud()
        {
            return longitud;
        }
        public int SetLongitud()
        {
            return this.longitud;
        }
        public string GetContraseña()
        {
            return contraseña;
        }

        public bool esFuerte()
        {
            int mayusculas = 0, minusculas = 0, numeros = 0;

            foreach (char c in contraseña)
            {
                if (char.IsUpper(c))
                {
                    mayusculas++;
                }
                else if (char.IsLower(c))
                {
                    minusculas++;
                }
                else if (char.IsDigit(c))
                {
                    numeros++;
                }
            }

            return (mayusculas > 2 && minusculas > 1 && numeros > 5);
        }

        private string generarPassword()
        {
            StringBuilder sb = new StringBuilder();
            Random semilla = new Random();
            char c;

            for (int i = 0; i < longitud; i++)
            {
                c = (char)semilla.Next(33, 126);
                sb.Append(c);
            }

            return sb.ToString();
        }
    }


