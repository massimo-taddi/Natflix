using Utility;

namespace Natflix.Models.Classi_Oggetto
{
    public class DettagliUtente : Entity
    {
        public int Id { get; set; }
        public DettagliUtente() { }


        public string Nome { get; set; }
        public string Cognome { get; set; }

        public DateTime DataNascita { get; set; }
        public string Indirizzo { get; set; }
        public int NumeroTelefono { get; set; }

        public int IdUtenti { get; set; }

        public Utenti Utenti { get; set; }

        public DettagliUtente(int id, string nome, string cognome,
                              DateTime dataNascita, string indirizzo,
                              int numeroTelefono, int idUtenti, Utenti utenti) : base(id)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            Indirizzo = indirizzo;
            NumeroTelefono = numeroTelefono;
            IdUtenti = idUtenti;
            Utenti = utenti;
        }


    }
}
