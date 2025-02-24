using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Model.Sql
{
    public class Produto
    {
        public Guid ProductID { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public Int64? StockQuantity { get; set; }
       
    }
}
