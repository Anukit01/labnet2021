using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico04.LOGIC
{
    interface IBaseLogic<T>
    {
        List<T> Getall();
        void Add(T item);
        void Delete(int id);
        void Delete(string id);
        void Update(T item);
        T GetById(int id);
        T GetById(string id);

    }
}
