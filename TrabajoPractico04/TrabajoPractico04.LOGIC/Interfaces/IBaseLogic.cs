using System.Collections.Generic;

namespace TrabajoPractico04.LOGIC
{
    interface IBaseLogic<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
       
    }
}
