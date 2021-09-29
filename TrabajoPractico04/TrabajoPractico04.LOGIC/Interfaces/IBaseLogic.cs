using System.Collections.Generic;

namespace TrabajoPractico04.LOGIC
{
    internal interface IBaseLogic<T>
    {
        List<T> Getall();
        void Add(T item);
        void Update(T item);
       
    }
}
