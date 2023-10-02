using Utility;

namespace Natflix.Models.DAO.Film
{
    public class DAOPreferitiFilm : IDAO
    {
        private Database db;
        private static DAOPreferitiFilm instance = null;
        private DAOPreferitiFilm()
        {
            db = new Database("Netflix");
        }
        public static DAOPreferitiFilm getInstance()
        {

            if (instance == null)
            {
                return instance = new DAOPreferitiFilm();
            }
            return instance;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entity e)
        {
            throw new NotImplementedException();
        }

        public List<Entity> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(Entity e)
        {
            throw new NotImplementedException();
        }
    }
}
