using Natflix.Models.Classi_Oggetto.Utente;
using Utility;

namespace Natflix.Models.DAO.Utente
{
    public class DAOUtente : IDAO
    {
        private Database db;
        private static DAOUtente instance = null;
        private DAOUtente()
        {
            db = new Database("Netflix");
        }
        public static DAOUtente getInstance()
        {

            if (instance == null)
            {
                return instance = new DAOUtente();
            }
            return instance;
        }
        public bool Delete(int id)
        {
            return db.Update($"DELETE FROM Utenti where id={id}");
        }

        public Entity Find(int id)
        {
            foreach (Entity e in Read())
            {
                if (e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        public bool Insert(Entity e)
        {
            return db.Update($"INSERT INTO Utenti" +
                             $"(nome_utente,passw,ruolo) " +
                             $"VALUES " +
                             $"('{((Utenti)e).Nome_Utente}', " +
                             $" HASHBYTES('Sha2_512','{((Utenti)e).PassW}'), " +
                             $" {((Utenti)e).Ruolo})");
        }

        public List<Entity> Read()
        {
            List<Entity> ris = new List<Entity>();
            List<Dictionary<string, string>> righe = db.Read("Select * from Utenti");
            foreach (Dictionary<string, string> r in righe)
            {
                Utenti u = new Utenti();
                u.FromDictionary(r);
                ris.Add(u);
            }
            return ris;
        }

        public bool Update(Entity e)
        {
            return db.Update($"UPDATE Utenti SET " +
                             $"nome_utente='{((Utenti)e).Nome_Utente}'," +
                             $"passw='{((Utenti)e).PassW}'," +
                             $"ruolo='{((Utenti)e).Ruolo}'");
        }
    }
}
