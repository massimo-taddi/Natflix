using Utility;

namespace Natflix.Models.DAO.SerieTv
{
    public class DAODettagliSerieTv : IDAO
    {
        private Database db;
        private static DAODettagliSerieTv instance = null;
        private DAODettagliSerieTv()
        {
            db = new Database("Netflix");
        }
        public static DAODettagliSerieTv getInstance()
        {

            if (instance == null)
            {
                return instance = new DAODettagliSerieTv();
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
