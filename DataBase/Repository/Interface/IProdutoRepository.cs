using System.Collections.Generic;
using System.Threading.Tasks;
using projetos.DataBase.Repository.Interfaces.Base;
using projetos.Models;

namespace projetos.DataBase.Repository.Interfaces
{
    public class ProdutoRepository : IBase<Produto>
    {
        public void Create(Produto t)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> GetId(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Update(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}