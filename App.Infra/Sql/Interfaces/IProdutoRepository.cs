using App.Core.Model.Sql;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Sql.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutoAsync();
        Task<Produto> GetProdutoIdAsync(Guid id);
        Task<Produto> InsertProdutoIdAsync(Produto produto);
        Task<Produto> UpdateProdutoAsync(Produto produto);
        Task<bool> DeleteProdutoIdAsync(Guid id);
    }
}
