using Utility;
namespace Natflix.Models.Classi_Oggetto
{
    public class DettagliSerieTv : Entity
    {


        public int Id { get; set; }
        public string URLEpisodio { get; set; }
        public string URLTrailer { get; set; }
        public int NumeroStagioni { get; set; }
        public int NumeroEpisodi { get; set; }
        public SerieTv IdSerietv { get; set; }


        public DettagliSerieTv(int id, string uRLEpisodio, string uRLTrailer,
                               int numeroStagioni, int numeroEpisodi, SerieTv idSerietv) : base(id)
        {
            Id = id;
            URLEpisodio = uRLEpisodio;
            URLTrailer = uRLTrailer;
            NumeroStagioni = numeroStagioni;
            NumeroEpisodi = numeroEpisodi;
            IdSerietv = idSerietv;
        }
    }
}
