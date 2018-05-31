using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projects.Models.ModelInterfaces
{
    interface ICrud<T>
    {
        void Create(T obj);
        T GetObjectByID(int id);
        List<T> GetListOfObjects();
        void Update(T obj);
        void Remove(int id);
    }
}
