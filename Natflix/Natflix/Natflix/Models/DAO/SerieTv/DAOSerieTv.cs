using Utility;

namespace Natflix.Models.DAO.SerieTv
{
    public class DAOSerieTv : IDAO
    {
        private Database db;
        private static DAOSerieTv instance = null;
        private DAOSerieTv()
        {
            db = new Database("Netflix");
        }
        public static DAOSerieTv getInstance()
        {

            if (instance == null)
            {
                return instance = new DAOSerieTv();
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
