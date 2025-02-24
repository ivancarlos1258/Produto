
using App.Core.Model.Sql;
using App.Infra.Sql.Interfaces;
using App.Infra.SQL.Context;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Sql.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SqlContext _sqlContext;
        public ProdutoRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<IEnumerable<Produto>> GetProdutoAsync()
        {

            var list = await _sqlContext.Produto.ToListAsync();
            return list;
        }

        public async Task<Produto> GetProdutoIdAsync(Guid id)
        {
            var item = await _sqlContext.Produto.FirstAsync(x => x.ProductID == id);
            return item;
        }

        public async Task<Produto> InsertProdutoIdAsync(Produto produto)
        {

            await _sqlContext.Produto.AddAsync(produto);

            _sqlContext.SaveChanges();
            return produto;
        }

        public async Task<Produto> UpdateProdutoAsync(Produto produto)
        {
            var item = _sqlContext.Produto.FirstOrDefault(x => x.ProductID == produto.ProductID);

            if (item != null)
            {
                item.Name = produto.Name;
                item.Price = produto.Price;
                item.StockQuantity = produto.StockQuantity;
            }
            _sqlContext.Produto.Update(produto);
            await _sqlContext.SaveChangesAsync();
            return produto;
        }

        public async Task<bool> DeleteProdutoIdAsync(Guid id)
        {
            var item = _sqlContext.Produto.FirstOrDefault(x => x.ProductID == id);

            if (item != null)
            {
                _sqlContext.Produto.Remove(item);
                await _sqlContext.SaveChangesAsync();
            }
            return true;
        }
    }
}
