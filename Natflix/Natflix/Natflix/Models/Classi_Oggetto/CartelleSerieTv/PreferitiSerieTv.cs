using Natflix.Models.Classi_Oggetto.Utente;
using Utility;

namespace Natflix.Models.Classi_Oggetto.SerieTv.SerieTv
{
    public class PreferitiSerieTv : Entity
    {


        public int Id { get; set; }
        public Utenti Utente { get; set; }
        public SerieTv SerieTv { get; set; }

        public PreferitiSerieTv(int id, Utenti utente, SerieTv serieTv) : base(id)
        {
            Id = id;
            Utente = utente;
            SerieTv = serieTv;
        }

    }
}
