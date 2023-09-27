using Utility;

namespace Natflix.Models.DAO
{
    public class DAOPreferitiSerieTv : IDAO
    {
        private Database db;
        private static DAOPreferitiSerieTv instance = null;
        private DAOPreferitiSerieTv()
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
