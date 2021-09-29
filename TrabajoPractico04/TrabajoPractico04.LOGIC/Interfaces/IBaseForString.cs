namespace TrabajoPractico04.LOGIC.Interfaces
{
    interface IBaseForString<T>
    {
        void Delete(string id);
        T GetById(string id);
    }
}
