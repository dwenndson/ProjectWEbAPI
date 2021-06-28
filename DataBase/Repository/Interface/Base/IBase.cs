using System.Collections.Generic;
using System.Threading.Tasks; 

namespace projetos.DataBase.Repository.Interfaces.Base
{
    public interface IBase<T>
    {
        Task<T> GetId(long id);
        void Create(T _object);
        IEnumerable<T> GetAll();
        Task<string> Update(long id);
        Task<string> Delete(long id);
    }
}