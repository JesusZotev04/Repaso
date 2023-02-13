using System.Text.RegularExpressions;

class Password {
    private int longitud = 8;
    private string contrasenya = default; 

    public Password(in int longitud) {
        this.longitud = longitud;
    }
    public Password() { }

    public bool EsFuerte(in string contrasenya) {
        string patron = @"^([A-Z]{2,})([a-z]+)(\d{5,})$";

        return Regex.IsMatch(contrasenya, patron);
    }
    public void GenerarPassword(in int longitud) {
        Random semilla = new Random();

        for (int i = 0; i < longitud; i++) {
            this.contrasenya += (char)semilla.Next(32, 122); // ASCII
        }
    }

    public string GetConstranya() {
        return this.contrasenya;
    }
    public int GetLongitud() {
        return longitud;
    }
    public void SetLongitud(in int longitud) {
        this.longitud = longitud;
    }
}