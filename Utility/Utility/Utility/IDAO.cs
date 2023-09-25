using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public interface IDAO
    {
        //un interfaccia con i metodi CRUD e il find       
        
            public List<Entity> Read();
            public bool Update(Entity e);
            public bool Insert(Entity e);
            public bool Delete(int id);
            public Entity Find(int id);


        
    }
}
