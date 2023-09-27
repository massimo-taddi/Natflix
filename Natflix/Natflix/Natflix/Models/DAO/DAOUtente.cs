using Utility;

namespace Natflix.Models.DAO
{
    public class DAOUtente : IDAO
    {
        private Database db;
        private static DAOUtente instance = null;
        private DAOUtente()
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
