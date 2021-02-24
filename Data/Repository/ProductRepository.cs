using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repository
{
    public class ProductRepository : GenericsRepository<Product>, IProduct
    {
        // public Task<List<Product>> CustomList()
        // {
            
        // }
    }
}