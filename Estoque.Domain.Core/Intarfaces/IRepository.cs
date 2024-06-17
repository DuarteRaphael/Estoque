using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Core.Intarfaces
{
    public interface IRepository<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        Task CadastrarAsync(TEntity entity);
        Task AtualizarAsynk(TEntity entity);
        Task ExcluirAsynk(TEntity entity);
        Task<List<TEntity>> BuscarTodos(int page, int limit);
        Task<TEntity> BuscarPorId(TKey id);
    }
}
