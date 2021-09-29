namespace TrabajoPractico04.LOGIC.Interfaces
{
    interface IBaseForInt<T>
    {
        void Delete(int id);
        T GetById(int id);
    }
}
