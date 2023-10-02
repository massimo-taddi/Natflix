using Natflix.Models.Classi_Oggetto;
using Natflix.Models.Classi_Oggetto.Utente;
using Utility;

namespace Natflix.Models.DAO.Utente
{
    public class DAODettagliUtente : IDAO
    {
        private Database db;
        private static DAODettagliUtente instance = null;
        private DAODettagliUtente()
        {
            db = new Database("Netflix");
        }
        public static DAODettagliUtente getInstance()
        {

            if (instance == null)
            {
                return instance = new DAODettagliUtente();
            }
            return instance;
        }
        public bool Delete(int id)
        {
            return db.Update($"DELETE FROM DettagliUtente where id={id}");
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
            return db.Update($"INSERT INTO DettagliUtente " +
                             $"(Nome,Cognome,DataNascita) " +
                             $"VALUES" +
                             $"(Nome='{((DettagliUtente)e).Nome}', " +
                             $" Cognome='{((DettagliUtente)e).Cognome}', " +
                             $" DataNascita={((DettagliUtente)e).DataNascita})");
        }

        public List<Entity> Read()
        {
            List<Entity> list = new List<Entity>();
            List<Dictionary<string, string>> righe = db.Read("Select * from DettagliUtente");
            foreach (Dictionary<string, string> r in righe)
            {
                DettagliUtente dettagli =new DettagliUtente();
                dettagli.FromDictionary(r);
                list.Add(dettagli);
            }
            return list;
        }

        public bool Update(Entity e)
        {
            throw new NotImplementedException();
        }
    }
}
