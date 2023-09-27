using Utility;

namespace Natflix.Models
{
    public class PreferitiFilm:Entity
    {
      

        public int Id {  get; set; }
        public Utenti Utenti { get; set; }
        public Film Film { get; set; }

        public PreferitiFilm(int id, Utenti utenti, Film film):base(id)
        {
            Id = id;
            Utenti = utenti;
            Film = film;
        }

    }
}
