internal class Program
{
    private static int ContarEntregados(Array array) {
        int numeroEntregados = 0;

        if(array is Videojuego[]) {
            foreach(Videojuego v in array)
                numeroEntregados += (v.IsEntregado()) ? 1 : 0;
        } else if(array is Serie[]){
            foreach(Serie s in array) 
                numeroEntregados += (s.IsEntregado()) ? 1 : 0;
        }
            
        return numeroEntregados;
    }
    private static Serie DevolverSerieConMasTemporadas(Serie[] series) {
        Serie serieConMasTemporadas;

        serieConMasTemporadas = series[0];
        foreach(Serie s in series) {
            if(s.GetNumeroTemporadas() > serieConMasTemporadas.GetNumeroTemporadas()) 
                serieConMasTemporadas = s;
        }

        return serieConMasTemporadas;
    }
    private static Videojuego DevolverVideojuegoConMasHorasEstimadas(Videojuego[] videojuegos) {
        Videojuego videojuegoConMasHorasEstimadas;

        videojuegoConMasHorasEstimadas = videojuegos[0];
        foreach(Videojuego v in videojuegos) {
            if(v.GetHorasEstimadas() > videojuegoConMasHorasEstimadas.GetHorasEstimadas()) 
                videojuegoConMasHorasEstimadas = v;
        }

        return videojuegoConMasHorasEstimadas;
    }
    private static void Main(string[] args)
    {
        Serie[] series = new Serie[5];
        Videojuego[] videojuegos = new Videojuego[5];

        series[0] = new Serie("Peaky Blinders", "Tom Harper", 6, "Drama");
        series[1] = new Serie("Breaking Bad", "Vince Gilligan", 5, "Drama criminal");
        series[2] = new Serie("Game of Thrones", "David Benioff", 8, "Fantasía");
        series[3] = new Serie("The Crown", "Peter Morgan", 5, "Drama histórico");
        series[4] = new Serie("Stranger Things", "The Duffer Brothers", 4, "Ciencia ficción y terror");

        videojuegos[0] = new Videojuego("The Legend of Zelda: Breath of the Wild", 50, "Acción y aventura", "Nintendo");
        videojuegos[1] = new Videojuego("Red Dead Redemption 2", 60, "Acción y aventura", "Rockstar Games");
        videojuegos[2] = new Videojuego("The Witcher 3: Wild Hunt", 70, "RPG", "CD Projekt");
        videojuegos[3] = new Videojuego("Fortnite", 100, "Battle Royale", "Epic Games");
        videojuegos[4] = new Videojuego("Overwatch", 40, "Shooter en primera persona", "Blizzard Entertainment");

        series[0].Entregar();
        series[4].Entregar();
        videojuegos[0].Entregar();
        videojuegos[3].Entregar();
        videojuegos[4].Entregar();

        Console.WriteLine($"Series entregadas: {ContarEntregados(series)}");
        Console.WriteLine($"Videojuegos entregados: {ContarEntregados(videojuegos)}");
        Console.WriteLine($"- - -\nSERIE CON MÁS TEMPORADAS\n- - -\n{DevolverSerieConMasTemporadas(series)}");
        Console.WriteLine($"- - -\nVIDEOJUEGO CON MÁS HORAS ESTIMADAS\n- - -\n{DevolverVideojuegoConMasHorasEstimadas(videojuegos)}");
    }
}