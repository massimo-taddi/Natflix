using Utility;

namespace Natflix.Models.DAO
{
    public class DAOFilm : IDAO
    {
        private Database db;
        private static DAOFilm instance = null;
        private DAOFilm()
        {
            db = new Database("Netflix");
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
