class Serie : Entregable {
    private string titulo = default;
    private int numeroTemporadas = 3;
    private bool entregado = false;
    private string genero = default;
    private string creador = default;

    public Serie() { }
    public Serie(in string titulo, in string creador) {
        this.titulo = titulo;
        this.creador = creador;
    }
    public Serie(in string titulo, in string creador, in int numeroTemporadas, in string genero) {
        this.titulo = titulo;
        this.creador = creador;
        this.numeroTemporadas = numeroTemporadas;
        this.genero = genero;
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
        Serie serie = null;

        if(objeto is Serie) 
            serie = (Serie)objeto;

        return (this.numeroTemporadas > serie.GetNumeroTemporadas());
    }

    public string GetTitulo() {
        return this.titulo;
    }
    public string GetGenero() {
        return this.genero;
    }
    public string GetCreador() {
        return this.creador;
    }
    public int GetNumeroTemporadas() {
        return this.numeroTemporadas;
    }
    
    public override string ToString() {
        return $"Título: {titulo}\nNúmero de temporadas: {numeroTemporadas}\nEntregado: {entregado}\nGénero: {genero}\nCreador: {creador}";
    }
}