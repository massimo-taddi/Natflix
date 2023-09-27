using Utility;
namespace Natflix.Models
{
    public class Film:Entity
    {
   
        public int Id {  get; set; }
        public string Titolo {  get; set; }
        public string Genere { get; set; }
        public DateTime Uscita { get; set; }
        public string Descrizione {  get; set; }
        public string Regista { get; set; }
        public string Locandina {  get; set; }

        public Film(int id, string titolo, string genere, DateTime uscita,
                    string descrizione, string regista, string locandina): base(id)
        {
            Id = id;
            Titolo = titolo;
            Genere = genere;
            Uscita = uscita;
            Descrizione = descrizione;
            Regista = regista;
            Locandina = locandina;
        }

    }
}
