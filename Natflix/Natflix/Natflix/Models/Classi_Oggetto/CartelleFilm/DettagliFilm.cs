using Utility;
namespace Natflix.Models.Classi_Oggetto.Film.Film
{
    public class DettagliFilm : Entity
    {


        public int Id { get; set; }
        public string Descrizione { get; set; }
        public string URLVideo { get; set; }
        public string AttoreProtagonista { get; set; }
        public Film IDFilm { get; set; }

        public DettagliFilm(int id, string descrizione,
                            string uRLVideo,
                            string attoreProtagonista, Film iDFilm) : base(id)
        {
            Id = id;
            Descrizione = descrizione;
            URLVideo = uRLVideo;
            AttoreProtagonista = attoreProtagonista;
            IDFilm = iDFilm;
        }
    }
}
