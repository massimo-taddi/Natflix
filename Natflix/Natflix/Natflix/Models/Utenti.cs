using Utility;

namespace Natflix.Models
{
    public class Utenti:Entity
    {
    

        public int Id { get; set; }
        public string Nome_Utente { get; set; }
        public string PassW {  get; set; }
        public string Ruolo {  get; set; }

        public Utenti(int id, string nome_Utente,
                      string passW, string ruolo) : base(id)
        {
            Id = id;
            Nome_Utente = nome_Utente;
            PassW = passW;
            Ruolo = ruolo;
        }

    }
}
