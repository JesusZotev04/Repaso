class Videojuego : Entregable {
    private string titulo = default;
    private int horasEstimadas = 10;
    private bool entregado = false;
    private string genero = default;
    private string companya = default;

    public Videojuego() {}
    public Videojuego(in string titulo, in int horasEstimadas) {
        this.titulo = titulo;
        this.horasEstimadas = horasEstimadas;
    }
    public Videojuego(in string titulo, in int horasEstimadas, in string genero, in string companya) {
        this.titulo = titulo;
        this.horasEstimadas = horasEstimadas;
        this.genero = genero; 
        this.companya = companya;
    }

    public void Entregar() {
        this.entregado = true;
    }

    public void Devolver() {
        this.entregado = false;
    }

    public bool IsEntregado() {
        return this.entregado;
    }

    public bool CompareTo(Object objeto) {
        Videojuego videojuego = null;

        if(objeto is Videojuego)
            videojuego = (Videojuego)objeto;

        return (this.horasEstimadas > videojuego.GetHorasEstimadas());
    }

    public string GetTitulo() {
        return titulo;
    }
    public int GetHorasEstimadas() {
        return horasEstimadas;
    }
    public string GetGenero() {
        return genero;
    }
    public string GetCompanya() {
        return companya;
    }

    public void SetTitulo(in string titulo) {
        this.titulo = titulo;
    }
    public void SetHorasEstimadas(in int horasEstimadas) {
        this.horasEstimadas = horasEstimadas;
    }
    public void SetGenero(in string genero) {
        this.genero = genero;
    }
    public void SetCompanya(in string companya) {
        this.companya = companya;
    }

    public override string ToString() {
        return $"Título: {titulo}\nHoras estimadas: {horasEstimadas}\nGénero: {genero}\nCompañia: {companya}";
    }
}